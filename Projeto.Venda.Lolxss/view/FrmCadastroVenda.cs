using Projeto.Venda.Lolxss.Controle;
using Projeto.Venda.Lolxss.model;

namespace Projeto.Venda.Lolxss.view
{
    public partial class CadastroVenda : Form
    {
        private Controleproduto ControleProduto;
        private ControleVenda VendaControle;
        private List<Item> carrinho = new List<Item>();

        public CadastroVenda()
        {
            InitializeComponent();
            ControleProduto = new Controleproduto();
            VendaControle = new ControleVenda();
        }

        private void CarregarProdutos()
        {
            List<Produto> lista = ControleProduto.ListarProdutos();
            cbxprodutos.DataSource = lista;
            cbxprodutos.DisplayMember = "nome";
            cbxprodutos.ValueMember = "cod_prod";
        }

        private void ConfigurarCaryinho()
        {
            this.dgvcompras.AutoGenerateColumns = false;
            this.dgvcompras.Columns.Clear();
            this.dgvcompras.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "produto",
                Name = "coluna produto",
                DataPropertyName = "nome_produto"
            });
            this.dgvcompras.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "quantidade",
                Name = "coluna quantidade",
                DataPropertyName = "quantidade"
            });
            this.dgvcompras.Columns.Add(
                new DataGridViewButtonColumn
                {
                    HeaderText = "Excluir",
                    Name = "Coluna excluir",
                    Text = "Excluir",
                    UseColumnTextForButtonValue = true


                });
            this.dgvcompras.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "preço unitario",
                Name = "coluna preco",
                DataPropertyName = "preco_real",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2"
                }
            });
            this.dgvcompras.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "sub total",
                Name = "coluna sub total",
                DataPropertyName = "sub_total",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2"
                }
            });
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Produto produto = cbxprodutos.SelectedItem as Produto;
            this.lblprecounitario.Text = $"Preço Unitário: R$ {produto.precoreal:C2}";
            this.lblquantidade.Text = $"Quantidade Disponivel: {produto.quantidade}";
            this.numquantidade.Maximum = produto.quantidade;
            this.numquantidade.Value = (this.numquantidade.Maximum > 0) ? 1 : 0;
        }

        private void frmcadproduto_Load(object sender, EventArgs e)
        {
            ConfigurarCaryinho();
            CarregarProdutos();
            AtualizarCarrinho();
        }

        public void AtualizarCarrinho()
        {
            this.dgvcompras.DataSource = this.carrinho.ToList();
            this.btncadastrar.Enabled = this.carrinho.Count() > 0;
            decimal total = this.carrinho.Sum(item => item.sub_total);
            this.precototal.Text = $"Total da venda: {total:C2}";
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            Produto produto = this.cbxprodutos.SelectedItem as Produto;
            int quantidade = (int)this.numquantidade.Value;
            if(quantidade < 1)
            {
                MessageBox.Show("produto no estoque zerado");
                    return;
            }

            Item? itemExistente = this.carrinho.FirstOrDefault(item => item.cod_prod == produto.cod_prod);
            if (itemExistente == null)
            {
                Item novoitem = new Item
                {
                    cod_prod = produto.cod_prod,
                    nome_produto = produto.nome,
                    preco = produto.preco,
                    quantidade = quantidade,
                    marca_produto = produto.marca,
                };
                this.carrinho.Add(novoitem);
            }
            else
            {
                itemExistente.quantidade += quantidade;
            }
            produto.quantidade -= quantidade;
            this.cbxprodutos.SelectedItem = produto;
            comboBox1_SelectedIndexChanged(this, EventArgs.Empty);

            AtualizarCarrinho();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            decimal total = this.carrinho.Sum(item => item.sub_total);
            DialogResult confirmador = MessageBox.Show($"deseja efetuar a venda no valor{total}", "confirmar venda",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmador == DialogResult.No)
            {
                return;
            }
            //enviar dados para o Controle

            try
            {
                bool resposta = VendaControle.cadastrarVenda(this.carrinho);
                if (resposta)
                {
                    carrinho.Clear();
                    frmcadproduto_Load(this, EventArgs.Empty);
                    MessageBox.Show("venda cadastrada com sucesso!!!", "cadastro da venda");

                }
                else
                {
                    MessageBox.Show("erro ao cadastrar venda", "erro cadastro venda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro no cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvcompras_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (this.dgvcompras.Columns[e.ColumnIndex].Name == "Coluna excluir")
            {

                ExcluirItemCarrinho(e.RowIndex);
               
            }
          
        }
        private void ExcluirItemCarrinho(int indice)
        {
           
            DialogResult confirmador = MessageBox.Show($"deseja exluir o item?", "excluir item",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmador == DialogResult.No)
            {
                return;
            }
            this.carrinho.RemoveAt(indice);
            AtualizarCarrinho();
            //excluir o item
        }
    }
}

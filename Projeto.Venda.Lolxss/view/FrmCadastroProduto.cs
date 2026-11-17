using Projeto.Venda.Lolxss.Controle;
using Projeto.Venda.Lolxss.model;
using Projeto.Venda.Lolxss.repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projeto.Venda.Lolxss.view
{
    public partial class CadastroProduto : Form
    {
        private Controleproduto Controle;

        private Produto? ProdutoSelecionado;

        private int TotalDePaginas = 5;
        private int PaginaAtual = 1;
        private int totalporpagina = 5;
        public CadastroProduto()
        {
            InitializeComponent();
            Controle = new Controleproduto();
        }
        private void frmcadastro_Load(object sender, EventArgs e)
        {
            //finalizar produtos
            CarregarProdutos();
            this.cbxquantidade.SelectedIndex = 0;
            //int pages = Controle.QuantidadePorPagina(5);S
            //lbl.Text = $" 1 de {pages}";
        }
        private void btn_cad_Click(object sender, EventArgs e)
        {
            string nome = this.txtnome.Text;
            string marca = this.txtmarca.Text;
            int preco =Convert.ToInt32(this.txtpreco.Text);
            int quantidade = Convert.ToInt32(this.quantidade.Text);
            //enviar para o Controle
            Produto Produto = new Produto
            {
                nome = nome,
                marca = marca,
                preco = preco,
                quantidade = quantidade
            };
            try
            {
            bool resp = Controle.CriarProduto(Produto);
                if (resp)
                {
                    MessageBox.Show("cadastrar com sucesso", "cadastro do produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarProdutos();
                    LimparCampos();


                }
                else
                {
                    MessageBox.Show("erro ao cadastrar", "cadastro do produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                CarregarProdutos();
            }
            catch(Exception ex) 
            {
                //mostrar o porque do erro
                MessageBox.Show(ex.Message, "cadastro do produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private void CarregarProdutos()
        {
            TotalDePaginas = Controle.QuantidadePorPagina(totalporpagina);
            if (PaginaAtual > TotalDePaginas)
            {
                PaginaAtual = TotalDePaginas;
            }
            atualizarLbl();


            List<Produto> list = Controle.ListarPelaPagina(totalporpagina, PaginaAtual);
            dgvprodutos.DataSource = list;
            this.dgvprodutos.Columns["id_funcionario"].Visible = false;


        }
        private void LimparCampos()
        {
            this.txtnome.Clear();
            this.txtmarca.Clear();
            this.txtpreco.Clear();
            this.quantidade.Value = 0;
        }
        private void atualizar_Click(object sender, EventArgs e)
        {
            //evento de atualizar
            ProdutoSelecionado.nome = this.txtnome.Text;
            ProdutoSelecionado.preco = Convert.ToInt32(this.txtpreco.Text);
            ProdutoSelecionado.marca = this.txtmarca.Text;
            ProdutoSelecionado.quantidade = (int)this.quantidade.Value;
            bool resp = Controle.Atualizar(ProdutoSelecionado);
            if (resp)
            {
                MessageBox.Show("curso atualizado com sucesso", "1155 do ET",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                CarregarProdutos();
                this.atualizar.Enabled = false;
                this.excluir.Enabled = false;
            }

        }
        private void dgvprodutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow linha = this.dgvprodutos.Rows[e.RowIndex];
            Produto? produto = linha.DataBoundItem as Produto;

            this.txtnome.Text = produto.nome;
            this.txtmarca.Text = produto.marca;
            this.txtpreco.Text = produto.preco.ToString();
            this.quantidade.Value = produto.quantidade;
            ProdutoSelecionado = produto;
            this.atualizar.Enabled = true;
            this.excluir.Enabled = true;
            return;
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            bool resp = Controle.Deletar(ProdutoSelecionado);
            if (resp)
            {
                MessageBox.Show("produto deletado", "remoçao de produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                CarregarProdutos();
                this.atualizar.Enabled = false;
                this.excluir.Enabled = false;
            }
            else
            {
                MessageBox.Show("erro ao excluir o produto", "remoçao de produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.atualizar.Enabled = false;
                this.excluir.Enabled = false;
                ProdutoSelecionado = null;
            }
        }

        //manipular as paginas
        private void proximo_Click(object sender, EventArgs e)
        {
            if (PaginaAtual < TotalDePaginas)
            {
                PaginaAtual++;
                atualizarLbl();
                CarregarProdutos();
            }
        }

        private void atualizarLbl()
        {
            this.lbl.Text = $"{PaginaAtual} de {TotalDePaginas}";
        }

        private void anterior_Click(object sender, EventArgs e)
        {
            if (PaginaAtual > 1)
            {
                PaginaAtual--;
                atualizarLbl();
                CarregarProdutos();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //capturar numeros
            this.totalporpagina = int.Parse(this.cbxquantidade.Text);
            //recalcular paginas
            CarregarProdutos();
        }
    }
}

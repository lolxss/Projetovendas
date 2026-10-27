using Projeto.Venda.Lolxss.controller;
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
    public partial class frmcadastro : Form
    {
        private productcontroller controller;

        private product? productselected;

        private int totaldepaginas = 5;
        private int paginaatual = 1;
        private int totalporpagina = 5;
        public frmcadastro()
        {
            InitializeComponent();
            controller = new productcontroller();
        }

        private void btn_cad_Click(object sender, EventArgs e)
        {
            string nome = this.txtnome.Text;
            string marca = this.txtmarca.Text;
            float preco = float.Parse(this.txtpreco.Text);
            int quantidade = Convert.ToInt32(this.quantidade.Text);
            //enviar para o controller
            product product = new product
            {
                nome = nome,
                marca = marca,
                preco = preco,
                quantidade = quantidade
            };
            productcontroller controller = new productcontroller();
            bool resp = controller.createproduct(product);
            if (quantidade < 0 || preco < 1)
            {
                MessageBox.Show("produto nao pode ter preco menor do que 1 ou quantidade menor do que 0", "cadastro do produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            else if (resp)
            {
                MessageBox.Show("cadastrar com sucesso", "cadastro do produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                carregarprodutos();
                limparcampos();


            }
            else
            {
                MessageBox.Show("erro ao cadastrar", "cadastro do produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmcadastro_Load(object sender, EventArgs e)
        {
            //finalizar produtos

            carregarprodutos();
            //int pages = controller.quantitybypage(5);
            //lbl.Text = $" 1 de {pages}";
        }
        private void carregarprodutos()
        {
            List<product> list = controller.getAll();
            dgvprodutos.DataSource = list;
            this.dgvprodutos.Columns["id_funcionario"].Visible = false;

            totaldepaginas = controller.quantitybypage(totalporpagina);
            if(paginaatual > totaldepaginas)
            {
                paginaatual = totaldepaginas;
            }

        }


        private void dgvprodutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void limparcampos()
        {
            this.txtnome.Clear();
            this.txtmarca.Clear();
            this.txtpreco.Clear();
            this.quantidade.Value = 0;
        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            //evento de atualizar
            productselected.nome = this.txtnome.Text;
            productselected.preco = Convert.ToInt32(this.txtpreco.Text);
            productselected.marca = this.txtmarca.Text;
            productselected.quantidade = (int)this.quantidade.Value;
            bool resp = controller.update(productselected);

            if (productselected.preco < 1 || productselected.quantidade < 0)
            {
                MessageBox.Show("produto nao pode ter preco menor do que 1 ou quantidade menor do que 0", "cadastro do produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (resp)
            {
                MessageBox.Show("curso atualizado com sucesso", "1155 do ET",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparcampos();
                carregarprodutos();
                this.atualizar.Enabled = false;
                this.excluir.Enabled = false;
            }

        }

        private void dgvprodutos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvprodutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow line = this.dgvprodutos.Rows[e.RowIndex];
            product? product = line.DataBoundItem as product;

            this.txtnome.Text = product.nome;
            this.txtmarca.Text = product.marca;
            this.txtpreco.Text = product.preco.ToString();
            this.quantidade.Value = product.quantidade;
            productselected = product;
            this.atualizar.Enabled = true;
            this.excluir.Enabled = true;
            return;
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            bool resp = controller.delete(productselected);
            if (resp)
            {
                MessageBox.Show("produto deletado", "remoçao de produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparcampos();
                carregarprodutos();
                this.atualizar.Enabled = false;
                this.excluir.Enabled = false;
            }
            else
            {
                MessageBox.Show("erro ao excluir o produto", "remoçao de produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.atualizar.Enabled = false;
                this.excluir.Enabled = false;
                productselected = null;
            }
        }
        //manipular as paginas
        private void proximo_Click(object sender, EventArgs e)
        {
            if(paginaatual < totaldepaginas)
            {
             paginaatual++;
                atualizarlbl();
                carregarprodutos();
            }
        }
        private void atualizarlbl()
        {
            this.lbl.Text = $"{paginaatual} de {totaldepaginas}";
        }

        private void anterior_Click(object sender, EventArgs e)
        {
            if (paginaatual > totaldepaginas)
            {
                paginaatual--;
                atualizarlbl();
                carregarprodutos();
            }
        }
    }
}

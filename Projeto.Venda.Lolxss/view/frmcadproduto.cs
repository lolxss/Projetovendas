using Projeto.Venda.Lolxss.controller;
using Projeto.Venda.Lolxss.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projeto.Venda.Lolxss.view
{
    public partial class frmcadproduto : Form
    {
        private productcontroller ProductController;
        private List<item> carrinho = new List<item>();

        public frmcadproduto()
        {
            InitializeComponent();
            ProductController = new productcontroller();
        }

        private void carregarProdutos()
        {
            List<Product> lista = ProductController.listproducts();
            cbxprodutos.DataSource = lista;
            cbxprodutos.DisplayMember = "nome";
            cbxprodutos.ValueMember = "cod_prod";
        }

        private void configurarcarrinho()
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
            Product produto = cbxprodutos.SelectedItem as Product;
            this.lblprecounitario.Text = $"Preço Unitário: R$ {produto.precoreal:C2}";
            this.lblquantidade.Text = $"Quantidade Disponivel: {produto.quantidade}";
            this.numquantidade.Maximum = produto.quantidade;
            this.numquantidade.Value = (this.numquantidade.Maximum > 0) ? 1 : 0;
        }

        private void frmcadproduto_Load(object sender, EventArgs e)
        {
            configurarcarrinho();
            carregarProdutos();
            atualizarcarrinho();
        }

        public void atualizarcarrinho()
        {
            this.dgvcompras.DataSource = null;
            this.dgvcompras.DataSource = this.carrinho;
            this.btncadastrar.Enabled = this.carrinho.Count() > 0;
            decimal total = this.carrinho.Sum(item => item.sub_total);
            this.precototal.Text = $"Total da venda: {total:C2}";
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            Product product = this.cbxprodutos.SelectedItem as Product;
            int quantidade = (int)this.numquantidade.Value;
            
            item? itemExistente = this.carrinho.FirstOrDefault(item => item.cod_prod == product.cod_prod);
            if (itemExistente == null)
            {
                item novoitem = new item
                {
                    cod_prod = product.cod_prod,
                    nome_produto = product.nome,
                    preco = product.preco,
                    quantidade = quantidade,
                    marca_produto = product.marca,
                };
                this.carrinho.Add(novoitem);
            }
            else
            {
                itemExistente.quantidade += quantidade;
            }
            product.quantidade -= quantidade;
            this.cbxprodutos.SelectedItem = product;
            comboBox1_SelectedIndexChanged(this, EventArgs.Empty);
            
            atualizarcarrinho();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            decimal total = this.carrinho.Sum(item => item.sub_total);
            DialogResult confirmer = MessageBox.Show($"deseja efetuar a venda no valor{total}","confirmar venda",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmer == DialogResult.No) 
            {
                return;
            }
            //enviar dados para o controle
            carrinho.Clear();
            frmcadproduto_Load(this, EventArgs.Empty);
            MessageBox.Show("venda cadastrada com sucesso!!!");
          
        }
    }
}

using Projeto.Venda.Lolxss.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projeto.Venda.Lolxss.view
{
    public partial class frmfuncionario : Form
    {
        public frmfuncionario()
        {
            InitializeComponent();
        }

        private void txtcomplemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmfuncionario_Load(object sender, EventArgs e)
        {

        }
        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }
        private void limparcampos()
        {
            this.txtnome.Clear();
            this.txttelefone.Clear();
            this.txtrua.Clear();
            this.txtcomplemento.Clear();
            this.txtcep.Clear();
            this.txtnumero.Clear();
            this.txtusuario.Clear();
            this.txtsenha.Clear();
            this.txtsenha2.Clear();
        }
        private void btnCadastrar_click(object sender, EventArgs e)
        {
            string nome = txtnome.Text;
            string telefone = txttelefone.Text;
            string rua = txtrua.Text;
            string complemento = txtcomplemento.Text;
            string cep = txtcep.Text;
            string numero = txtnumero.Text;
            string usuario = txtusuario.Text;
            string senha = txtsenha.Text;
            string confirmarsenha = txtsenha2.Text;
            if (senha != confirmarsenha)
            {
                MessageBox.Show("senhas nao concidem",
                    "senhas sao diferentes",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                    return;
            }
            //chamar o controador do usuario para criar cadastro
            Employeecontroler controller = new Employeecontroler();
            bool resp = controller.createEmployee(nome, telefone, rua, complemento, cep, numero, usuario, senha);
            if (resp)
            {
                MessageBox.Show("cadastrar com sucesso", "cadastro funcionario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparcampos();

            }
            else
            {
                MessageBox.Show("erro ao cadastrar", "cadastro funcionario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    
    }
}

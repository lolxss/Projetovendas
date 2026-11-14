using Projeto.Venda.Lolxss.Controle;
using Projeto.Venda.Lolxss.model;
using Projeto.Venda.Lolxss.repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;


namespace Projeto.Venda.Lolxss.view
{
    public partial class frmCadastroFuncionario : Form
    {
        private ControleFuncionario Controle;
       
        public frmCadastroFuncionario()
        {
            InitializeComponent();
            Controle = new ControleFuncionario();
            this.cbxadm.SelectedIndex = 0;
            
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            CarregarFuncionario();

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
            bool adm = (this.cbxadm.SelectedIndex == 0)? false : true;
            if (senha != confirmarsenha)
            {
                MessageBox.Show("senhas nao concidem",
                    "senhas sao diferentes",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            Funcionario funcionario = new Funcionario
            {
                nome = nome,
                usuario = usuario,
                telefone = telefone,
                senha = senha,
                rua = rua,
                numero = numero,
                complemento = complemento,
                cep = cep,
                ADM = adm

            };
            //chamar o controador do usuario para criar cadastro
            ControleFuncionario controller = new ControleFuncionario();
            bool resp = controller.CriarFuncionario(funcionario);
            if (resp)
            {
                MessageBox.Show("cadastrar com sucesso", "cadastro funcionario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarFuncionario();
                limparcampos();

            }
            else
            {
                MessageBox.Show("erro ao cadastrar", "cadastro funcionario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void CarregarFuncionario()
        {
            List<Funcionario> lista = Controle.PegueTudo();
            dgvfuncionario.DataSource = lista;
            this.dgvfuncionario.Columns["senha"].Visible = false;
        }
        
        
    }
}

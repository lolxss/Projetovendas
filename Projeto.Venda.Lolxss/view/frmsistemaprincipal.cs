using Projeto.Venda.Lolxss.Controle;
using Projeto.Venda.Lolxss.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Windows.Forms;
using Projeto.Venda.Lolxss.model;
namespace Projeto.Venda.Lolxss.view

{
    public partial class FrmSistemaPrincipal : Form
    {

        private ControleFuncionario Controle;
        private Funcionario funcionario;
        public FrmSistemaPrincipal()
        {
            InitializeComponent();
            Controle = new ControleFuncionario();
            Funcionario? funcionario = Controle.UsuarioAutenticado();
            string nome = (funcionario != null) ? funcionario.nome : "";
            this.Text += $"- {nome}";
        }


        private void frmsistemaprincipal_Load(object sender, EventArgs e)
        {
            bool ADM = Controle.UsuarioAdministrador();
            if (!ADM)
            {
                this.btncadfuncionario.Visible = false;
            }


            lblnome.Text = Controle.UsuarioAutenticado()?.nome ?? "";


        }
        private void ExibirFrm(Form formulario)
        {
            while (painelprincipal.Controls.Count > 0)
            {
                painelprincipal.Controls[0].Dispose();
            }
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            this.lblTitulo.Text = formulario.Text;

            painelprincipal.Controls.Add(formulario);
            formulario.Show();
          
        }

        private void btncadfuncionario_Click(object sender, EventArgs e)
        {
            CadastroFuncionario frm = new CadastroFuncionario();
            ExibirFrm(frm);
            lblnome.Visible = false;
        }

        private void cad_prod_Click(object sender, EventArgs e)
        {
            CadastroProduto frm = new CadastroProduto();
            ExibirFrm(frm);
            lblnome.Visible = false;
        }

        private void sair_Click(object sender, EventArgs e)
        {
            //evento para sair
            this.DialogResult = DialogResult.Retry;
            this.Dispose();
        }

        private void usuario_Click(object sender, EventArgs e)
        {
            PerfilUsuario frm = new PerfilUsuario();
            ExibirFrm(frm);
            lblnome.Visible = false;
        }

        private void cad_venda_Click(object sender, EventArgs e)
        {
            CadastroVenda frm = new CadastroVenda();
            ExibirFrm(frm);
            lblnome.Visible = false;
        }
    }
}

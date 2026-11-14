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
namespace Projeto.Venda.Lolxss.view
{
    public partial class FrmSistemaPrincipal : Form
    {
        private ControleFuncionario Controle;
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
            painelprincipal.Controls.Add(formulario);
            formulario.Show();
        }

        private void btncadfuncionario_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario frm = new frmCadastroFuncionario();
            ExibirFrm(frm);
        }

        private void cad_prod_Click(object sender, EventArgs e)
        {
            FrmCadastroProduto frm = new FrmCadastroProduto();
            ExibirFrm(frm);

        }

        private void painelprincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sair_Click(object sender, EventArgs e)
        {
            //evento para sair
            this.DialogResult = DialogResult.Retry;
            this.Dispose();
        }

        private void usuario_Click(object sender, EventArgs e)
        {
            FrmPerfilUsuario frm = new FrmPerfilUsuario();
            ExibirFrm(frm);
        }

        private void cad_venda_Click(object sender, EventArgs e)
        {
            frmCadastroVenda frm = new frmCadastroVenda();
            ExibirFrm(frm);
        }
    }
}

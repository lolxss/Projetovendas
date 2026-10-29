using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Projeto.Venda.Lolxss.controller;
namespace Projeto.Venda.Lolxss.view
{
    public partial class frmsistemaprincipal : Form
    {
        public frmsistemaprincipal()
        {
            InitializeComponent();
        }

        private void frmsistemaprincipal_Load(object sender, EventArgs e)
        {
            //string usuario = session.usuario;
            bool isADMIN = session.isADMIN;
            //    this.lblusername.Text = usuario;
        }
        private void exibirfrm(Form formulario)
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
            frmfuncionario frm = new frmfuncionario();
            exibirfrm(frm);
        }

        private void cad_prod_Click(object sender, EventArgs e)
        {
            frmcadastro frm = new frmcadastro();
            exibirfrm(frm);

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
    }
}

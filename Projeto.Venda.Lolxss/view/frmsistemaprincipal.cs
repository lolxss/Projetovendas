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
            //bool isADMIN = session.isADMIN;
            //    this.lblusername.Text = usuario;
        }

        private void btncadfuncionario_Click(object sender, EventArgs e)
        {
            frmfuncionario frm = new frmfuncionario();
            frm.ShowDialog();
        }

        private void cad_prod_Click(object sender, EventArgs e)
        {
            frmcadastro frm = new frmcadastro();
            frm.ShowDialog();
        }
    }
}

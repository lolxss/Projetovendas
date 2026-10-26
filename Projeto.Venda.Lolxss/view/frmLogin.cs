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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_entrar(object sender, EventArgs e)
        {


            string usuario = this.txtuser.Text;
            string senha = this.txtpassword.Text;


            if (Employeecontroler.login(usuario, senha))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                MessageBox.Show("usuario ou senha nao identificados",
                    "erro de login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Projeto.Venda.Lolxss.Controle;
namespace Projeto.Venda.Lolxss.view
{
    public partial class FrmSessão : Form
    {
        public FrmSessão()
        {
            InitializeComponent();
        }

        private void btn_entrar(object sender, EventArgs e)
        {


            string usuario = this.txtuser.Text;
            string senha = this.txtpassword.Text;


            if (ControleFuncionario.Sessão(usuario, senha))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                MessageBox.Show("usuario ou senha nao identificados",
                    "erro de Sessão",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

       
    }
}

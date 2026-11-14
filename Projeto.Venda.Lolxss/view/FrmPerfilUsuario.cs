using Projeto.Venda.Lolxss.Controle;
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
    public partial class FrmPerfilUsuario : Form
    {
        private ControleFuncionario controle;
        private Funcionario funcionario;
        public FrmPerfilUsuario()
        {
            InitializeComponent();
            controle = new ControleFuncionario();
            FrmUsuarioCarregar();
        }

        private void FrmUsuarioCarregar()
        {
            funcionario = controle.UsuarioAutenticado();
            if (funcionario != null)
            {
                CarregarDados();
            }
        }
        private void CarregarDados()
        {
            nomebox.Text = funcionario.nome;
            usuariobox.Text = funcionario.usuario;
            telefonebox.Text = funcionario.telefone;
                ruabox.Text = funcionario.rua;
            compbox.Text = funcionario.complemento;
            cepbox.Text = funcionario.cep;
            enderecobox.Text = funcionario.endereço;

          

   }    } 
}

using Projeto.Venda.Lolxss.controller;
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
    public partial class perfiluser : Form
    {
        private Employeecontroler controller;
        private employee funcionario;
        public perfiluser()
        {
            InitializeComponent();
            controller = new Employeecontroler();
            frmusuarioload();
        }

        private void frmusuarioload()
        {
            funcionario = controller.usuarioautenticado();
            if (funcionario != null)
            {
                carregardados();
            }
        }
        private void carregardados()
        {
            nomebox.Text = funcionario.nome;
            usuariobox.Text = funcionario.usuario;
            telefonebox.Text = funcionario.telefone;
                ruabox.Text = funcionario.rua;
            compbox.Text = funcionario.complemento;
            cepbox.Text = funcionario.cep;
            enderecobox.Text = funcionario.endereço;

            usuariobox.Text = funcionario.usuario;

   }    } 
}

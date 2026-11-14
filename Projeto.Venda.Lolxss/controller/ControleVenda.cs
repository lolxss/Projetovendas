using Projeto.Venda.Lolxss.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Venda.Lolxss.Controle
{
    internal class ControleVenda
    {
        ControleFuncionario ControleFuncionario;

            public ControleVenda()
        {
            ControleFuncionario = new ControleFuncionario();
        }

        public bool cadastrarVenda(List<Item>itens)
        {
            Funcionario? Employee = ControleFuncionario.UsuarioAutenticado();
            if (Employee == null)
            {
                throw new Exception("usuario nao autenticado");


            }
            int id_funcionario = Employee.id_funcionario;
            Vendas venda = new Vendas
            {
                id_funcionario = id_funcionario,
                itens = itens
            };
            return true;
        }
    }
}

using Projeto.Venda.Lolxss.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Venda.Lolxss.controller
{
    internal class Vendacontroller
    {
        Employeecontroler employeecontroler;

            public Vendacontroller()
        {
            employeecontroler = new Employeecontroler();
        }

        public bool cadastrarVenda(List<item>itens)
        {
            employee? Employee = employeecontroler.usuarioautenticado();
            if (Employee == null)
            {
                throw new Exception("usuario nao autenticado");


            }
            int id_funcionario = Employee.id_funcionario;
            venda Venda = new venda
            {
                id_funcionario = id_funcionario,
                itens = itens
            };
            return true;
        }
    }
}

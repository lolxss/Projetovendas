using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Venda.Lolxss.model;
using Projeto.Venda.Lolxss.repository;
namespace Projeto.Venda.Lolxss.controller
{
    internal class Employeecontroler
    {
        private EmployeeRepository repository;
        public Employeecontroler()
        {
            repository = new EmployeeRepository();

        }

        public static bool login(string username, string password)
        {
            EmployeeRepository repository = new EmployeeRepository();
            employee? resp = repository.getbyusername(username);
            if (resp == null)
            {
                return false;
            }
            //resp.senha ="123"
            //password = "123"

            //resp.senha ="kdigfshjklfgndsihgiorhiojgifdjgijewopigjsdx"
            //password = "123"
            bool validatepassword;

            try
            {
                validatepassword = BCrypt.Net.BCrypt.Verify(password, resp.senha);
            }
            catch (Exception ex)
            {
                validatepassword = false;
            }
            if (!validatepassword)
            {
                return false;
            }
            //gravar os dados do usuario logado!!!!!
            session.userAuth = resp;
            return true;
        }

        public bool createEmployee(employee employee)
        {
            //fazer verificaçao se o usuario nao existe
            //solicitar ao repository se o suario existe ou nao
            EmployeeRepository repository = new EmployeeRepository();
            employee? resp = repository.getbyusername(employee.usuario);
            if (resp != null)
            {
                return false;
            }
            string senha = BCrypt.Net.BCrypt.HashPassword(employee.senha);
            employee.senha = senha;
                       
            repository.Createemployee(employee);
            return true;
        }

        public employee? usuarioautenticado()
        {
            return session.userAuth;
        }
       
        public List<employee> getAll()
        {
            return repository.getAllfuncionario();

        }

        public bool userADM()
        {
            if (session.userAuth == null)
            {
                return false;

            }
            return session.userAuth.ADM;
        }







    }

}

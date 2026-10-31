using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Venda.Lolxss.model;
using Projeto.Venda.Lolxss.repository;
namespace Projeto.Venda.Lolxss.controller
{
    internal class Employeecontroler
    {
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

        public bool createEmployee(string nome, string usuario,
            string telefone, string senha, string rua, string numero, string complemento, string cep)
        {
            //fazer verificaçao se o usuario nao existe
            //solicitar ao repository se o suario existe ou nao
            EmployeeRepository repository = new EmployeeRepository();
            employee? resp = repository.getbyusername(usuario);
            if (resp != null)
            {
                return false;
            }
            string hash = BCrypt.Net.BCrypt.HashPassword(senha);
            employee funcionario = new employee
            {
                nome = nome,
                usuario = usuario,
                telefone = telefone,
                senha = hash,
                rua = rua,
                numero = numero,
                complemento = complemento,
                cep = cep

            };
            repository.Createemployee(funcionario);
            return true;
        }

        public employee? usuarioautenticado()
        {
            return session.userAuth;
        }











    }

}

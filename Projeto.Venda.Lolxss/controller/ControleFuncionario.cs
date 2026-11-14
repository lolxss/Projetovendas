using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Venda.Lolxss.model;
using Projeto.Venda.Lolxss.repository;
namespace Projeto.Venda.Lolxss.Controle
{
    internal class ControleFuncionario
    {
        private RepositorioFuncionario Repositorio;
        public ControleFuncionario()
        {
            Repositorio = new RepositorioFuncionario();

        }

        public static bool Sessão(string usuario, string senha)
        {
            RepositorioFuncionario repositorio = new RepositorioFuncionario();
            Funcionario? resp = repositorio.PegarPorNomeDeUsuario(usuario);
            if (resp == null)
            {
                return false;
            }
            //resp.senhacriptografada ="123"
            //senhacriptografada = "123"

            //resp.senhacriptografada ="kdigfshjklfgndsihgiorhiojgifdjgijewopigjsdx"
            //senhacriptografada = "123"
            bool validarsenha;

            try
            {
                validarsenha = BCrypt.Net.BCrypt.Verify(senha, resp.senha);
            }
            catch (Exception ex)
            {
                validarsenha = false;
            }
            if (!validarsenha)
            {
                return false;
            }
            //gravar os dados do usuario logado!!!!!
            Controle.Sessão.UsuarioAutenticado = resp;
            return true;
        }

        public bool CriarFuncionario(Funcionario funcionario)
        {
            //fazer verificaçao se o usuario nao existe
            //solicitar ao Repositorio se o suario existe ou nao
            RepositorioFuncionario repositorio = new RepositorioFuncionario();
            Funcionario? resp = repositorio.PegarPorNomeDeUsuario(funcionario.usuario);
            if (resp != null)
            {
                return false;
            }
            string senhacriptografada = BCrypt.Net.BCrypt.HashPassword(funcionario.senha);
            funcionario.senha = senhacriptografada;
                       
            repositorio.CriarFuncionario(funcionario);
            return true;
        }

        public Funcionario? UsuarioAutenticado()
        {
            return Controle.Sessão.UsuarioAutenticado;
        }
       
        public List<Funcionario> PegueTudo()
        {
            return Repositorio.PegueTodosOsFuncionarios();

        }

        public bool UsuarioAdministrador()
        {
            if (Controle.Sessão.UsuarioAutenticado == null)
            {
                return false;

            }
            return Controle.Sessão.UsuarioAutenticado.ADM;
        }







    }

}

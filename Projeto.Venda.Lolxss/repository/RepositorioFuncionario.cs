
using MySqlConnector;
using Projeto.Venda.Lolxss.database;
using Projeto.Venda.Lolxss.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
namespace Projeto.Venda.Lolxss.repository
{
    internal class RepositorioFuncionario
    {
        private Funcionario Mapear(MySqlDataReader cursor)
        {
            return new Funcionario
            {
                id_funcionario = cursor.GetInt32("id_funcionario"),
                nome = cursor.GetString("nome"),
                usuario = cursor.GetString("usuario"),
                senha = cursor.GetString("senha"),
                telefone = cursor.GetString("telefone"),
                rua = (cursor.IsDBNull(cursor.GetOrdinal("rua"))) ? null : cursor.GetString("rua"),
                numero = cursor.GetString("numero"),
                complemento = (cursor.IsDBNull(cursor.GetOrdinal("complemento"))) ? null : cursor.GetString("complemento"),
                cep = cursor.GetString("cep"),
                ADM = cursor.GetBoolean("ADM")
            };
        }
        public Funcionario? PegarPorNomeDeUsuario(string usuario)
        {
            using MySqlConnection conector = BancoDeDados.Conexao();
            string sql = "SELECT * FROM funcionario WHERE usuario = @username";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            cmd.Parameters.AddWithValue("@username", usuario);
            using var cursor = cmd.ExecuteReader();
            if (cursor.Read())
            {
                return Mapear(cursor);

            }
            return null;
        }
        public int CriarFuncionario(Funcionario funcionario)
        {
            using MySqlConnection conexao = BancoDeDados.Conexao();
            string sql = @"insert INTO funcionario
          (nome,usuario,telefone,senha,rua,numero,complemento,cep, ADM) VALUES
           (@nome,@usuario,@telefone,@senha,@rua,@numero,@complemento,@cep,@ADM)";
            using MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", funcionario.nome);
            cmd.Parameters.AddWithValue("@usuario", funcionario.usuario);
            cmd.Parameters.AddWithValue("@telefone", funcionario.telefone);
            cmd.Parameters.AddWithValue("@senha", funcionario.senha);
            cmd.Parameters.AddWithValue("@rua", funcionario.rua);
            cmd.Parameters.AddWithValue("@numero", funcionario.numero);
            cmd.Parameters.AddWithValue("@complemento",funcionario.complemento);
            cmd.Parameters.AddWithValue("@cep", funcionario.cep);
            cmd.Parameters.AddWithValue("@ADM", funcionario.ADM);
            cmd.ExecuteNonQuery();
            return (int)cmd.LastInsertedId;
        }
        public List<Funcionario> PegueTodosOsFuncionarios()
        {
            using MySqlConnection conector = BancoDeDados.Conexao();
            string sql = "SELECT * FROM funcionario";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            using var cursor = cmd.ExecuteReader();
            List<Funcionario> lista = new List<Funcionario>();
            while (cursor.Read())
            {
                lista.Add(Mapear(cursor));
            }
            return lista;
            //ExecuteReader() serve para comandos select
        }
    }
}

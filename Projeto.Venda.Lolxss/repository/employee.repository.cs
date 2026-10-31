
using MySqlConnector;
using Projeto.Venda.Lolxss.database;
using Projeto.Venda.Lolxss.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
namespace Projeto.Venda.Lolxss.repository
{
    internal class EmployeeRepository
    {
        private employee map(MySqlDataReader reader)
        {
            return new employee
            {
                id_funcionario = reader.GetInt32("id_funcionario"),
                nome = reader.GetString("nome"),
                usuario = reader.GetString("usuario"),
                senha = reader.GetString("senha"),
                telefone = reader.GetString("telefone"),
                rua = ( reader.IsDBNull(reader.GetOrdinal("rua"))) ? null : reader.GetString("rua"),
                numero = reader.GetString("numero"),
                complemento = (reader.IsDBNull(reader.GetOrdinal("complemento"))) ? null :reader.GetString("complemento"),
                cep = reader.GetString("cep")
            };
        }
        public employee? getbyusername(string username)
        {
            using MySqlConnection conector = DataBase.GetConnection();
            string sql = "SELECT * FROM funcionario WHERE usuario = @username";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            cmd.Parameters.AddWithValue("@username", username);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return map(reader);

            }
            return null;
        }
        public int Createemployee(employee employee)
        {
            using MySqlConnection connection = DataBase.GetConnection();
            string sql = @"insert INTO funcionario
          (nome,usuario,telefone,senha,rua,numero,complemento,cep) VALUES
           (@nome,@usuario,@telefone,@senha,@rua,@numero,@complemento,@cep)";
            using MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@nome", employee.nome);
            cmd.Parameters.AddWithValue("@usuario", employee.usuario);
            cmd.Parameters.AddWithValue("@telefone", employee.telefone);
            cmd.Parameters.AddWithValue("@senha", employee.senha);
            cmd.Parameters.AddWithValue("@rua", employee.rua);
            cmd.Parameters.AddWithValue("@numero", employee.numero);
            cmd.Parameters.AddWithValue("@complemento",employee.complemento);
            cmd.Parameters.AddWithValue("@cep", employee.cep);
            cmd.ExecuteNonQuery();
            return (int)cmd.LastInsertedId;
        }
    }
}

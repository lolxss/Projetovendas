using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Venda.Lolxss.database
{
    internal static class BancoDeDados
    {
        private static string TextoDeConexao;

        static BancoDeDados()
        {
            MySqlConnectionStringBuilder contrutor = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Port = 3306,
                Database = "db_vendas",
                UserID = "root",
                Password = ""

            };
            TextoDeConexao = contrutor.ConnectionString;
        }
        public static MySqlConnection Conexao()
        {
            MySqlConnection conexão = new MySqlConnection(TextoDeConexao);

            try
            {
                //try execute something 
                conexão.Open();
                return conexão;
            }
            catch (MySqlException ex)
            {
                //if doesnt work
                conexão.Dispose();
                throw;
            }


        }
    }
}

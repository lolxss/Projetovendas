using MySqlConnector;
using DotNetEnv;
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
            string caminho = Path.Combine(AppContext.BaseDirectory,".env");
            Env.Load(caminho);
            MySqlConnectionStringBuilder contrutor = new MySqlConnectionStringBuilder
            {

                Server = Env.GetString("DB_HOSTNAME"),
                Port = uint.Parse(Env.GetString("DB_PORT")),
                Database = Env.GetString("DB_NAME"),
                UserID = Env.GetString("DB_USER"),
                Password = Env.GetString("DB_PASSWORD")

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

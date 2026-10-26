using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Venda.Lolxss.database
{
    internal static class DataBase
    {
        private static string stringconnection;

        static DataBase()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Port = 3306,
                Database = "db_vendas",
                UserID = "root",
                Password = ""

            };
            stringconnection = builder.ConnectionString;
        }
        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(stringconnection);

            try
            {
                //try execute something 
                connection.Open();
                return connection;
            }
            catch (MySqlException ex)
            {
                //if doesnt work
                connection.Dispose();
                throw;
            }


        }
    }
}

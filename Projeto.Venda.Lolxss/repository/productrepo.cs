using MySqlConnector;
using Projeto.Venda.Lolxss.database;
using Projeto.Venda.Lolxss.model;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Projeto.Venda.Lolxss.repository
{
    internal class productrepo
    {
        private product map(MySqlDataReader reader)
        {
            return new product
            {
                id_funcionario = reader.GetInt32("id_funcionario"),
                cod_prod = reader.GetInt32("cod_prod"),
                nome = reader.GetString("nome"),
                marca = reader.GetString("marca"),
                preco = reader.GetFloat("preco"),
                quantidade = reader.GetInt32("quantidade"),

            };
        }
        public int Createproduct(product product)
        {
            using MySqlConnection connection = DataBase.GetConnection();
            string sql = @"insert INTO produtos
          (id_funcionario,nome,marca,preco,quantidade) VALUES
           (@id_funcionario,@nome,@marca,@preco,@quantidade)";
            using MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@id_funcionario", product.id_funcionario);
            cmd.Parameters.AddWithValue("@nome", product.nome);
            cmd.Parameters.AddWithValue("@marca", product.marca);
            cmd.Parameters.AddWithValue("@preco", product.preco);
            cmd.Parameters.AddWithValue("@quantidade", product.quantidade);
            cmd.ExecuteNonQuery();
            return (int)cmd.LastInsertedId;
            // cmd.ExecuteNonQuery(); use quand tem a ver quando preciso manipular os dados
        }

        public List<product> getAll()
        {
            using MySqlConnection conector = DataBase.GetConnection();
            string sql = "SELECT * FROM produtos";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            using var reader = cmd.ExecuteReader();
            List<product> list = new List<product>();
            while (reader.Read())
            {
                list.Add(map(reader));
            }
            return list;
            //ExecuteReader() serve para comandos select
        }

        public List<product> listperpage(int quantity, int page)
        {
            int offset = quantity * (page - 1);
            using MySqlConnection conector = DataBase.GetConnection();
            string sql = "SELECT * FROM produtos LIMIT @limit OFFSET @offset";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            cmd.Parameters.AddWithValue("@limit", quantity);
            cmd.Parameters.AddWithValue("@offset", offset);
            using var reader = cmd.ExecuteReader();

            List<product> list = new List<product>();
            while (reader.Read())
            {
                list.Add(map(reader));
            }
            return list;
        }
        public int productquantity()
        {
            using MySqlConnection connection = DataBase.GetConnection();
            string sql = "SELECT COUNT(*) FROM produtos";
            using MySqlCommand cmd = new MySqlCommand(sql, connection);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public bool update(product product)
        {
            using MySqlConnection connection = DataBase.GetConnection();
            string sql = @"UPDATE produtos SET
                    nome =@nome, marca=@marca, preco=@preco, quantidade=@quantidade
                      WHERE cod_prod =@cod_prod";
            using MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@cod_prod", product.id_funcionario);
            cmd.Parameters.AddWithValue("@nome", product.nome);
            cmd.Parameters.AddWithValue("@marca", product.marca);
            cmd.Parameters.AddWithValue("@preco", product.preco);
            cmd.Parameters.AddWithValue("@quantidade", product.quantidade);
            
           
            return cmd.ExecuteNonQuery() > 0;

        }
        //cmd.ExecuteScalar(); quando eu quero pegar uma unica informaçao

        public bool delete(int cod_prod)
        {
            using MySqlConnection connection = DataBase.GetConnection();
            string sql = @"DELETE FROM produtos WHERE cod_prod = @cod_prod";
            using MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@cod_prod", cod_prod);
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}


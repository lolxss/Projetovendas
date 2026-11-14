using MySqlConnector;
using Projeto.Venda.Lolxss.database;
using Projeto.Venda.Lolxss.model;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Projeto.Venda.Lolxss.repository
{
    internal class RepositorioProduto
    {
        private Produto Mapear(MySqlDataReader cursor)
        {
            return new Produto
            {
                id_funcionario = cursor.GetInt32("id_funcionario"),
                cod_prod = cursor.GetInt32("cod_prod"),
                nome = cursor.GetString("nome"),
                marca = cursor.GetString("marca"),
                preco = cursor.GetInt32("preco"),
                quantidade = cursor.GetInt32("quantidade"),

            };
        }
        
        public int CriarProduto(Produto produto)
        {
            using MySqlConnection conexao = BancoDeDados.Conexao();
            string sql = @"insert INTO produtos
          (id_funcionario,nome,marca,preco,quantidade) VALUES
           (@id_funcionario,@nome,@marca,@preco,@quantidade)";
            using MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_funcionario", produto.id_funcionario);
            cmd.Parameters.AddWithValue("@nome", produto.nome);
            cmd.Parameters.AddWithValue("@marca", produto.marca);
            cmd.Parameters.AddWithValue("@preco", produto.preco);
            cmd.Parameters.AddWithValue("@quantidade", produto.quantidade);
            cmd.ExecuteNonQuery();
            return (int)cmd.LastInsertedId;
            // cmd.ExecuteNonQuery(); use quand tem a ver quando preciso manipular os dados
        }

        public List<Produto> PegueTudo()
        {
            using MySqlConnection conector = BancoDeDados.Conexao();
            string sql = "SELECT * FROM produtos";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            using var reader = cmd.ExecuteReader();
            List<Produto> list = new List<Produto>();
            while (reader.Read())
            {
                list.Add(Mapear(reader));
            }
            return list;
            //ExecuteReader() serve para comandos select
        }

        public List<Produto> ListarPorPagina(int quantity, int page)
        {
            int offset = quantity * (page - 1);
            using MySqlConnection conector = BancoDeDados.Conexao();
            string sql = "SELECT * FROM produtos LIMIT @limit OFFSET @offset";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            cmd.Parameters.AddWithValue("@limit", quantity);
            cmd.Parameters.AddWithValue("@offset", offset);
            using var reader = cmd.ExecuteReader();

            List<Produto> list = new List<Produto>();
            while (reader.Read())
            {
                list.Add(Mapear(reader));
            }
            return list;
        }
        public int QuantidadeProduto()
        {
            using MySqlConnection connection = BancoDeDados.Conexao();
            string sql = "SELECT COUNT(*) FROM produtos";
            using MySqlCommand cmd = new MySqlCommand(sql, connection);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public bool Atualizar(Produto product)
        {
            using MySqlConnection connection = BancoDeDados.Conexao();
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

        public bool Deletar(int cod_prod)
        {
            using MySqlConnection connection = BancoDeDados.Conexao();
            string sql = @"DELETE FROM produtos WHERE cod_prod = @cod_prod";
            using MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@cod_prod", cod_prod);
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}


using MySqlConnector;
using Projeto.Venda.Lolxss.controller;
using Projeto.Venda.Lolxss.database;
using Projeto.Venda.Lolxss.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Venda.Lolxss.repository
{
    internal class repositoriodevendas
    {

        public bool cadastrarVenda(venda venda)
        {
            using MySqlConnection connection = DataBase.GetConnection();
            using MySqlTransaction transacao = connection.BeginTransaction();
            try
            {
                //bloquear os produtos
                foreach (var item in venda.itens)
                {
                    string sqlblock = @"SELECT * FROM produtos
                        WHERE cod_prod = @cod_prod FOR UPDATE";
                    using var cmdblock = new MySqlCommand(sqlblock, connection, transacao);
                    cmdblock.Parameters.AddWithValue("@cod_prod", item.cod_prod);
                    using var reader = cmdblock.ExecuteReader();
                    if (!reader.Read())
                    {
                        throw new Exception("produto erro no registro");
                    }
                
                
                }

                //registrar a venda

                string sqlregister = @"INSERT INTO venda(id_funcionario) VALUES (@id_funcionario)";
                using var cmdvenda = new MySqlCommand(sqlregister, connection, transacao);
                cmdvenda.Parameters.AddWithValue("@cod_prod", venda.id_funcionario);
                cmdvenda.ExecuteNonQuery();
                venda.cod_venda = (int)cmdvenda.LastInsertedId;
                //using var reader = cmd.ExecuteReader();

                //resgistrar os itens
                foreach (item  item in venda.itens)

                //atualizar a quantidade de itens do produto



                transacao.Commit();
                return true;
            }
            catch (Exception ex)
            { 
              transacao.Rollback();

                throw ex;
            
            };
        }
    }
}

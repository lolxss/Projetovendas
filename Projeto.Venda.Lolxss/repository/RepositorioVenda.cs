using MySqlConnector;
using Projeto.Venda.Lolxss.Controle;
using Projeto.Venda.Lolxss.database;
using Projeto.Venda.Lolxss.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Venda.Lolxss.repository
{
    internal class RepositorioVenda
    {

        public bool cadastrarVenda(Vendas venda)
        {
            using MySqlConnection conexao = BancoDeDados.Conexao();
            using MySqlTransaction transacao = conexao.BeginTransaction();
            try
            {
                //bloquear os produtos
                foreach (var item in venda.itens)
                {
                    string sqlblock = @"SELECT * FROM produtos
                        WHERE cod_prod = @cod_prod FOR UPDATE";
                    using var cmdblock = new MySqlCommand(sqlblock, conexao, transacao);
                    cmdblock.Parameters.AddWithValue("@cod_prod", item.cod_prod);
                    using var cursor = cmdblock.ExecuteReader();
                    if (!cursor.Read())
                    {
                        throw new Exception("produto erro no registro");
                    }
                
                
                }

                //registrar a Vendas

                string sqlregistrador = @"INSERT INTO venda(id_funcionario) VALUES (@id_funcionario)";
                using var cmdvenda = new MySqlCommand(sqlregistrador, conexao, transacao);
                cmdvenda.Parameters.AddWithValue("@cod_prod", venda.id_funcionario);
                cmdvenda.ExecuteNonQuery();
                venda.cod_venda = (int)cmdvenda.LastInsertedId;
                //using var cursor = cmd.ExecuteReader();

                //resgistrar os itens
                foreach (Item  item in venda.itens)

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

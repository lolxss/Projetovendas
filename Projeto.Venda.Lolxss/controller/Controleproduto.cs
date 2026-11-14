using MySqlConnector;
using Projeto.Venda.Lolxss.database;
using Projeto.Venda.Lolxss.model;
using Projeto.Venda.Lolxss.repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Venda.Lolxss.Controle
{
    internal class Controleproduto
    {
        public bool CriarProduto(Produto product)
        {
            int id_funcionario = Sessão.UsuarioAutenticado.id_funcionario;
            product.id_funcionario = id_funcionario;
            Repositorio.CriarProduto(product);
            product.Validar();
            //fazer cadastro
            return true;

        }
        private RepositorioProduto Repositorio;
        public Controleproduto()
        {
            Repositorio = new RepositorioProduto();
       
        }
        public List<Produto> ListarProdutos()
        {
            return Repositorio.PegueTudo();
        }

        public List<Produto> ListarPelaPagina(int quantity, int page)
        {
            return Repositorio.ListarPorPagina(quantity, page);
        }
        
        public int QuantidadePorPagina(int quantidadeitem)
        {
            int quantidadeproduto = Repositorio.QuantidadeProduto();
            return (int)Math.Ceiling((decimal)quantidadeproduto / quantidadeitem);
        }
        
        public bool Atualizar(Produto produto)
        {
            return Repositorio.Atualizar(produto);  
        }

        public bool Deletar(Produto Produto)
        {
            return Repositorio.Deletar(Produto.cod_prod);
        }
    }
}

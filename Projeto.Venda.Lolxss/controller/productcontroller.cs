using MySqlConnector;
using Projeto.Venda.Lolxss.database;
using Projeto.Venda.Lolxss.model;
using Projeto.Venda.Lolxss.repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Venda.Lolxss.controller
{
    internal class productcontroller
    {
        public bool createproduct(Product product)
        {
            int id_funcionario = session.userAuth.id_funcionario;
            product.id_funcionario = id_funcionario;
            repository.Createproduct(product);
            product.validar();
            //fazer cadastro
            return true;

        }
        private productrepo repository;
        public productcontroller()
        {
            repository = new productrepo();
       
        }
        public List<Product> listproducts()
        {
            return repository.getAll();
        }

        public List<Product> listbypage(int quantity, int page)
        {
            return repository.listperpage(quantity, page);
        }
        
        public int quantitybypage(int itemsquantity)
        {
            int productquantity = repository.productquantity();
            return (int)Math.Ceiling((decimal)productquantity / itemsquantity);
        }
        
        public bool update(Product product)
        {
            return repository.update(product);  
        }

        public bool delete(Product product)
        {
            return repository.delete(product.cod_prod);
        }
    }
}

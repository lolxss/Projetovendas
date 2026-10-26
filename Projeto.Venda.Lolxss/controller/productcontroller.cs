using Projeto.Venda.Lolxss.model;
using Projeto.Venda.Lolxss.repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Venda.Lolxss.controller
{
    internal class productcontroller
    {
        public bool createproduct(product product)
        {
            int id_funcionario = session.userAuth.id_funcionario;
            product.id_funcionario = id_funcionario;
            repository.Createproduct(product);
            return true;
        }
        private productrepo repository;
        public productcontroller()
        {
            repository = new productrepo();
       
        }
        public List<product> getAll()
        {
            return repository.getAll();
        }
        public bool update(product product)
        {
    
            
                return repository.update(product);  
        }
        public bool delete(product product)
        {
            return repository.delete(product.cod_prod);
        }
    }
}

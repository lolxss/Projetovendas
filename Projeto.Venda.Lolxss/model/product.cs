using System;
using System.Collections.Generic;
using System.Text;


namespace Projeto.Venda.Lolxss.model
{
    internal class Product
    {
        public int cod_prod { get; set; }
        public string nome { get; set; }
        public string marca { get; set; }
        public int preco { get; set; }
        public int quantidade { get; set; }
        public int id_funcionario { get; set; }
        public DateTime dat_registro { get; set; }
        public decimal precoreal => this.preco / 100m;

        public void validar()
        {
            if(preco <= 0)
            {
                throw new ArgumentException("o preço nao pode ser zero");
            }
            if(quantidade < 0)
            {
                throw new ArgumentException("a quantidade nao pode ser menor que zero");
            }
        }

    }
}

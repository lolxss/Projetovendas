using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Venda.Lolxss.model
{
    internal class Item
    {
        public int cod_itens {  get; set; }
        public int cod_prod { get; set; }
        public int cod_venda { get; set; }
        public int quantidade { get; set; }
        public int preco { get; set; }

        public string nome_produto { get; set; }
        public string marca_produto { get; set; }


        public decimal preco_real => preco / 100m;

        public decimal sub_total => preco_real * quantidade;


    }

}

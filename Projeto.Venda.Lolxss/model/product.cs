using System;
using System.Collections.Generic;
using System.Text;


namespace Projeto.Venda.Lolxss.model
{
    internal class product
    {
        public int cod_prod { get; set; }
        public string nome { get; set; }
        public string marca { get; set; }
        public float preco { get; set; }
        public int quantidade { get; set; }
        public int id_funcionario { get; set; }
        public DateTime dat_registro { get; set; }


    }
}

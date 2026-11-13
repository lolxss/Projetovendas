using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Venda.Lolxss.model
{
    internal class venda
    {
        public int cod_venda {  get; set; }
        public int id_funcionario { get; set; }
        public DateTime data {  get; set; }
        public List<item> itens {  get; set; }
        public string nomefuncionario { get; set; }

    }
}

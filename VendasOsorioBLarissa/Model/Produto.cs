using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasOsorioBLarissa.Model
{
    class Produto
    {
        //Relacionamento 
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Double Quantidade { get; set; }

        public Double Preco { get; set; }

        public DateTime CriadoEm { get; set; }

        public Produto()
        {
            CriadoEm = DateTime.Now;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + " | Preço: " + Preco + " | Quantidade: " + Quantidade;
        }

    }
}

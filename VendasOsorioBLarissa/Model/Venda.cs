using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasOsorioBLarissa.Model
{
    class Venda
    {
        public Venda() { CriadoEm = DateTime.Now; }
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataVenda { get; set; }
        public DateTime CriadoEm { get; set; }

    }
}

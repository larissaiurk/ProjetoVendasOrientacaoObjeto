using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasOsorioBLarissa.Model
{
    class ItemVenda
    {
        public Produto Produto { get; set; }
        public Double Quantidade { get; set; }
        public Double Preco { get; set; }
        public DateTime CriadoEm { get; set; }

    }
}

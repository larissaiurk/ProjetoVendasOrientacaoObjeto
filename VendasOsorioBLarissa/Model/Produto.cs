using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasOsorioBLarissa.Model
{
    class Produto
    {

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public DateTime CriadoEm { get; set; }

        public Produto()
        {
            CriadoEm = DateTime.Now;
        }

    }
}

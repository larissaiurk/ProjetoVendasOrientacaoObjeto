using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasOsorioBLarissa.Model
{
    class Vendedor
    {

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public DateTime CriadoEm { get; set; }

        public Vendedor()
        {
            CriadoEm = DateTime.Now;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + " | CPF: " + Cpf;
        }

    }
}

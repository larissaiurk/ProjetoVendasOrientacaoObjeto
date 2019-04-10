using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasOsorioBLarissa.Model
{
    [Table("Clientes")]
    class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime CriadoEm { get; set; }
        public List<Venda> Vendas { get; set; }

        public Cliente()
        {
            CriadoEm = DateTime.Now;
        }
        public override string ToString()
        {
            return "Nome: " + Nome + " | CPF: " + Cpf;
        }
    }
}

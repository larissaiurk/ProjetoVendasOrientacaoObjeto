using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasOsorioBLarissa.Model
{
    [Table("ItensVenda")]
    class ItemVenda
    {
        [Key]
        public int ItemVendaId { get; set; }
        public Produto Produto { get; set; }
        public Double Quantidade { get; set; }
        public Double Preco { get; set; }
        public DateTime CriadoEm { get; set; }
        public Venda Venda { get; set; }

    }
}

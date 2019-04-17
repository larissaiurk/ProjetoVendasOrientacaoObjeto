using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasOsorioBLarissa.Model
{
    [Table("Produtos")]
    class Produto
    {
        //Relacionamento 
        [Key]
        public int ProdutoId { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public Double Quantidade { get; set; }
        public Double Preco { get; set; }
        public DateTime CriadoEm { get; set; }
        public List<ItemVenda> ItensVenda { get; set; }

        public Produto()
        {
            CriadoEm = DateTime.Now;
        }
        public override string ToString()
        {
            return "Código:" + Codigo +  " | Nome: " + Nome + " | Preço: " + Preco + " | Quantidade: " + Quantidade;
        }

    }
}

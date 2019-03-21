using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasOsorioBLarissa.Model
{
    class Venda
    {
        public Venda() {
            CriadoEm = DateTime.Now;
            ItensVenda = new List<ItemVenda>();
            Cliente = new Cliente();
            Vendedor = new Vendedor();
        }

        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public List<ItemVenda> ItensVenda { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataVenda { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            // (/t)
            double subtotal = 0, totalVenda = 0, totalGeral = 0;

            String retorno = " Cliente: " + Cliente.Nome + " | CPF: " + Cliente.Cpf + "\n" +
                " Vendedor: " + Vendedor.Nome + " | CPF: " + Vendedor.Cpf + "\n" +
                " Data: " + DataVenda;

            retorno = retorno + "\n ---- Itens da venda ---";

            for (int i = 0; i < ItensVenda.Count; i++)
            {
                retorno = retorno + "\n Item " + (i + 1) + ": " + ItensVenda[i].Produto.Nome + " | Quantidade "
                    + ItensVenda[i].Quantidade.ToString("C2") + " | Preço " + ItensVenda[i].Produto.Preco.ToString("C2") + "\n";
            }      

            retorno = retorno + "";

            return retorno;
        }

    }
}

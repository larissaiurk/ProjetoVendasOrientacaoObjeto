using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasOsorioBLarissa.Model;

namespace VendasOsorioBLarissa.DAL
{
    class VendaDAO
    {
        private static List<Venda> vendas = new List<Venda>();

        public static void CadastrarVenda(Venda v)
        {
            vendas.Add(v);
        }
        public static List<Venda> RetornarVendas()
        {
            return vendas;
        }

        public static List<Venda> BuscarVendasPorCpf(Cliente c)
        {
            List<Venda> aux = new List<Venda>();
            foreach (Venda vendaCadastrada in vendas)
            {
                if (vendaCadastrada.Cliente.Cpf.Equals(c.Cpf))
                {
                    aux.Add(vendaCadastrada);
                }
            }
            return aux;
        }
    }
}

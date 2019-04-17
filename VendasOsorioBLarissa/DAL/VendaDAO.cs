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
        private static Context ctx = SingletonContext.GetInstance();

        private static List<Venda> vendas = new List<Venda>();

        public static void CadastrarVenda(Venda v)
        {
            //vendas.Add(v);
            ctx.Vendas.Add(v);
            ctx.SaveChanges();
        }
        public static List<Venda> RetornarVendas()
        {
            return ctx.Vendas.ToList();
        }

        public static List<Venda> BuscarVendasPorCpf(Cliente c)
        {
            return ctx.Vendas.Include("Cliente").Where(x => x.Cliente.Cpf.Equals(c.Cpf)).ToList();
            /*List<Venda> aux = new List<Venda>();
            foreach (Venda vendaCadastrada in vendas)
            {
                if (vendaCadastrada.Cliente.Cpf.Equals(c.Cpf))
                {
                    aux.Add(vendaCadastrada);
                }
            }
            return aux;*/
        }
    }
}

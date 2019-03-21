using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasOsorioBLarissa.DAL;
using VendasOsorioBLarissa.Model;

namespace VendasOsorioBLarissa.View
{
    class ListarVenda
    {
        public static void Renderizar(List<Venda> vendas)
        {
            
            Console.Clear();
            Console.WriteLine("Listar Vendas");

            foreach (var venda in VendaDAO.RetornarVendas())
            {
                Console.WriteLine(venda.ToString() + "\n");
            }
        }
    }
}

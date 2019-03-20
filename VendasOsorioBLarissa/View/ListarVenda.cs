using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasOsorioBLarissa.DAL;

namespace VendasOsorioBLarissa.View
{
    class ListarVenda
    {
        public static void Renderizar()
        {
            Console.WriteLine("Listar Vendas");

            foreach (var venda in VendaDAO.RetornarVendas())
            {
                Console.WriteLine(venda.ToString() + "\n");
            }
        }
    }
}

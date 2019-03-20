using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasOsorioBLarissa.DAL;

namespace VendasOsorioBLarissa.View
{
    class ListarVendedor
    {
        public static void Renderizar()
        {
            Console.WriteLine("Listar Vendedores");
            foreach (var vendedorCadastrado in VendedorDAO.listarVendedores())
            {
                Console.WriteLine(vendedorCadastrado.ToString() + "\n");
            }
        }
    }
}

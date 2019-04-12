using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasOsorioBLarissa.DAL;
using VendasOsorioBLarissa.Model;

namespace VendasOsorioBLarissa.View
{
    class ListarClientes
    {
        public static void Renderizar()
        {
            Console.WriteLine(" -- LISTAR CLIENTES -- /n");

            foreach (Cliente clienteCadastrado in ClienteDAO.RetornarClientes())
            {
                Console.WriteLine(clienteCadastrado.ToString() + "\n");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasOsorioBLarissa.Model;

namespace VendasOsorioBLarissa.DAL
{
    class ClienteDAO
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public static void cadastrarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }


        public static List<Cliente> listarClientes()
        {
            return clientes;
        }


    }
}

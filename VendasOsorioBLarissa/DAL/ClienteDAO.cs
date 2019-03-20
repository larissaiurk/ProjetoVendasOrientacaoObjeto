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

        public static bool cadastrarCliente(Cliente cliente)
        {
            if (retornarCliente(cliente) == null)
            {
                clientes.Add(cliente);
                return true;
            }
            return false;
        }
        //CTRL + PONTO
        public static List<Cliente> listarClientes()
        {
            return clientes;
        }

        public static Cliente retornarCliente(Cliente cli)
        {
            foreach (var cliente in clientes)
            {
                if (cli.Cpf.Equals(cliente.Cpf))
                {
                    return cliente;
                }
            }   
            return null;

        }
            
        }

}


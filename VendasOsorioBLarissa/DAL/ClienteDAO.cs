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
        private static Context ctx = SingletonContext.GetInstance();

    /*    private static List<Cliente> clientes = new List<Cliente>();

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

        }*/
        
        
        //COM BANCO DE DADOS
        public static Cliente BuscarClientePorCpf(Cliente c)
        {
            return ctx.Clientes.FirstOrDefault(x => x.Cpf.Equals(c.Cpf));
        }
        public static bool CadastrarCliente(Cliente c)
        {
            if (BuscarClientePorCpf(c) == null)
            {
                ctx.Clientes.Add(c);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }
        public static List<Cliente> RetornarClientes()
        {
            return ctx.Clientes.ToList();
        }

        }

}


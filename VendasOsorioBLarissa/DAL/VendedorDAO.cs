using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasOsorioBLarissa.Model;

namespace VendasOsorioBLarissa.DAL
{
    class VendedorDAO
    {

        private static List<Vendedor> vendedores = new List<Vendedor>();

        public static bool cadastrarVendedor(Vendedor vendedor)
        {
            if (retornarVendedor(vendedor) == null)
            {
                vendedores.Add(vendedor);
                return true;
            }
            return false;
        }
        //CTRL + PONTO
        public static List<Vendedor> listarVendedores()
        {
            return vendedores;
        }

        public static Vendedor retornarVendedor(Vendedor ven)
        {
            foreach (var vendedor in vendedores)
            {
                if (ven.Cpf.Equals(vendedor.Cpf))
                {
                    return vendedor;
                }
            }
            return null;

        }

    }
}


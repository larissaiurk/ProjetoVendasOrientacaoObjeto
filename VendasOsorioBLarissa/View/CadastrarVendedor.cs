using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasOsorioBLarissa.DAL;
using VendasOsorioBLarissa.Model;

namespace VendasOsorioBLarissa.View
{
    class CadastrarVendedor
    {
        public static void Renderizar()
        {
            Console.Write("Cadastrar Vendedor");

            Vendedor v = new Vendedor();
            Console.WriteLine("Digite um nome");
            v.Nome = Console.ReadLine();
            Console.WriteLine("Digite um cpf");
            v.Cpf = Console.ReadLine();

            VendedorDAO.cadastrarVendedor(v);

            v = null;
            Console.WriteLine("Vendedor cadastrado com sucesso");
        }

    }
}

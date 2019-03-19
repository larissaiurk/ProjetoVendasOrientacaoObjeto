using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasOsorioBLarissa.DAL;
using VendasOsorioBLarissa.Model;

namespace VendasOsorioBLarissa.View
{
    class CadastrarCliente
    {
        public static void Renderizar()
        {
            Console.WriteLine("Cadastrar Cliente");

            Cliente c = new Cliente();
            Console.WriteLine("Digite um nome");
            c.Nome = Console.ReadLine();
            Console.WriteLine("Digite um cpf");
            c.Cpf = Console.ReadLine();

            ClienteDAO.cadastrarCliente(c);

            c = null;
            Console.WriteLine("Cliente cadastrado com sucesso");
        }
    }
}

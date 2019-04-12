using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasOsorioB.Utils;
using VendasOsorioBLarissa.DAL;
using VendasOsorioBLarissa.Model;

namespace VendasOsorioBLarissa.View
{
    class CadastrarCliente
    {
        public static void Renderizar()
        {
            Cliente c = new Cliente();
            Console.WriteLine("  -- CADASTRAR CLIENTE --  \n");
            Console.WriteLine("Digite o nome do cliente:");
            c.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do cliente:");
            c.Cpf = Console.ReadLine();
            if (Validacao.ValidarCpf(c.Cpf))
            {
                if (ClienteDAO.CadastrarCliente(c))
                {
                    Console.WriteLine("\n Cliente cadastrado com sucesso!");
                }
                else
                {
                    Console.WriteLine("\n Atenção! Esse cliente já existe!");
                }
            }
            else
            {
                Console.WriteLine("CPF inválido!");
            }

     
        }
    }
}

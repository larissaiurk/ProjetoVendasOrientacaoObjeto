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
    class CadastrarVendedor
    {
        public static void Renderizar()
        {
            Vendedor v = new Vendedor();
            Console.WriteLine("  -- CADASTRAR FUNCIONÁRIO --  \n");
            Console.WriteLine("Digite o nome do funcionário:");
            v.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do funcionário:");
            v.Cpf = Console.ReadLine();
            if (Validacao.ValidarCpf(v.Cpf))
            {
                if (VendedorDAO.CadastrarVendedor(v))
                {
                    Console.WriteLine("\n Funcionário cadastrado com sucesso!");
                }
                else
                {
                    Console.WriteLine("\n Atenção! Esse funcionário já existe!");
                }
            }
            else
            {
                Console.WriteLine("CPF inválido!");
            }
        }

    }
}

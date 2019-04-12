using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasOsorioBLarissa.DAL;
using VendasOsorioBLarissa.Model;

namespace VendasOsorioBLarissa.View
{
    class CadastrarProduto
    {
        public static void Renderizar()
        {
            Produto p = new Produto();
            Console.WriteLine("  -- CADASTRAR PRODUTO --  \n");
            Console.WriteLine("Digite o nome do produto:");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto:");
            p.Preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto:");
            p.Quantidade = Convert.ToDouble(Console.ReadLine());
            if (ProdutoDAO.CadastrarProduto(p))
            {
                Console.WriteLine("\n Produto cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("\n Esse produto já existe!");
            }

        }
    }
}

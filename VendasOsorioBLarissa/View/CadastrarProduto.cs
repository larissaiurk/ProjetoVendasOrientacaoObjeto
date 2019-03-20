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
            Console.WriteLine("Cadastro de Produto");

            Console.WriteLine("Digite um nome");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Digite o preço");
            p.Preco = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Digite a quantidade");
            p.Quantidade = Convert.ToDouble(Console.ReadLine());

            ProdutoDAO.cadastrarProduto(p);

            p = null;
            Console.WriteLine("Produto cadastrado com sucesso.");
        }
    }
}

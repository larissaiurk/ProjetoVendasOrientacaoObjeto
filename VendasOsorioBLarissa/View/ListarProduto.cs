using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasOsorioBLarissa.DAL;

namespace VendasOsorioBLarissa.View
{
    class ListarProduto
    {

        public static void Renderizar()
        {
            Console.WriteLine("Listar Produtos");

            foreach (var produto in ProdutoDAO.listarProdutos())
            {
                Console.WriteLine(produto.ToString() + "\n");
            }
        }

    }
}

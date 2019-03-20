using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasOsorioBLarissa.Model;

namespace VendasOsorioBLarissa.DAL
{
    class ProdutoDAO
    {

        private static List<Produto> produtos = new List<Produto>();

        public static void cadastrarProduto(Produto produto)
        {
            produtos.Add(produto);
        }


        public static List<Produto> listarProdutos()
        {
            return produtos;
        }

        public static Produto retornarProduto(Produto prod)
        {
            foreach (var p in produtos)
            {
                if (p.Codigo.Equals(prod.Codigo))
                {
                    return p;
                }

            }
            return null;
        }
    }
}

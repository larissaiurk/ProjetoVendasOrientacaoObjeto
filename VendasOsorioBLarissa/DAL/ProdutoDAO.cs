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
        public static Context ctx = SingletonContext.GetInstance();
      /*  private static List<Produto> produtos = new List<Produto>();

        public static bool cadastrarProduto(Produto produto)
        {
            if(retornarProduto(produto) == null) {  
                produtos.Add(produto);
                return true;
            }
            return false;
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
        }*/

        public static bool CadastrarProduto(Produto p)
        {
            if (BuscarProduto(p) == null)
            {
                ctx.Produtos.Add(p);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public static Produto BuscarProduto(Produto p)
        {
            return ctx.Produtos.FirstOrDefault(x => x.Codigo == p.Codigo);

        }

        public static List<Produto> RetornarProdutos()
        {
            return ctx.Produtos.ToList();
        }

    }
}

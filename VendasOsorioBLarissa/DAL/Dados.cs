using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasOsorioBLarissa.Model;

namespace VendasOsorioBLarissa.DAL
{
    class Dados
    {
        public static void Inserir()
        {
            //Assim já passa as informacoes na hora de criar o objeto
            Cliente c = new Cliente
            {
                Nome = "Larissa",
                Cpf = "00000000191",
                CriadoEm = DateTime.Now                
            };

            Vendedor v = new Vendedor
            {
                Nome = "Melissa",
                Cpf = "12345678909",
                CriadoEm = DateTime.Now
            };

            Produto p = new Produto
            {
                Codigo = 1,
                Nome = "Chocolate",
                Preco = 5.0,
                Quantidade = 100,
                CriadoEm = DateTime.Now
            };

            ProdutoDAO.CadastrarProduto(p);
            p = null;

            p = new Produto
            {
                Codigo = 2,
                Nome = "Água",
                Preco = 2.0,
                Quantidade = 100,
                CriadoEm = DateTime.Now
            };

            ProdutoDAO.CadastrarProduto(p);

            ClienteDAO.CadastrarCliente(c);
            VendedorDAO.CadastrarVendedor(v);
            


        }
    }
}

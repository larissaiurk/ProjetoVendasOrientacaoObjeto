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
                Codigo = 123,
                Nome = "Chocolate",
                Preco = 5.0,
                Quantidade = 100,
                CriadoEm = DateTime.Now
            };

            ProdutoDAO.cadastrarProduto(p);

            p = new Produto
            {
                Codigo = 123,
                Nome = "Água",
                Preco = 2.0,
                Quantidade = 100,
                CriadoEm = DateTime.Now
            };

            ProdutoDAO.cadastrarProduto(p);

            ClienteDAO.cadastrarCliente(c);
            VendedorDAO.cadastrarVendedor(v);
            


        }
    }
}

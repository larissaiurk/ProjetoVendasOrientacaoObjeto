using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasOsorioBLarissa.DAL;
using VendasOsorioBLarissa.Model;

namespace VendasOsorioBLarissa.View
{
    class CadastrarVenda
    {
        public static void Renderizar()
        {
            Console.WriteLine("Cadastrar Venda");

            Venda v = new Venda();
            Cliente c = new Cliente();
            Vendedor ven = new Vendedor();
            Produto p = new Produto();

            //Cliente
            Console.WriteLine("Digite o CPF do cliente");
            c.Cpf = Console.ReadLine();
            
            //Chamar o metodo de busca
            //Guardar o retorno do metodo
            //Verificar o que retorna - se retornar nullo nao continua
            //objeto null: informa uma mensagem de erro
            //objeto preenchido: guarda objeto dentro da venda

            c = ClienteDAO.retornarCliente(c);
            if(c != null)
            {
                v.Cliente = c;
                //Funcionario
                Console.WriteLine("Digite o CPF do funcionário:");
                ven.Cpf = Console.ReadLine();

                ven = VendedorDAO.retornarVendedor(ven);
                if (ven!=null)
                {

                    v.Vendedor = ven;
                    //Produto
                    Console.WriteLine("Digite o código do produto:");
                    p.Codigo = Convert.ToInt32(Console.ReadLine());
                    p = ProdutoDAO.retornarProduto(p);
                    if (p != null)
                    {
                        v.Produto = p;

                        Console.WriteLine();





                    }else
                    {
                        Console.WriteLine("Produto não cadastrado");
                    }


                }else
                {
                    Console.WriteLine("Vendedor não cadastrado");
                }


            }
            else
            {
                Console.WriteLine("Cliente não cadastrado");
            }                     
            Console.WriteLine("Venda cadastrada com sucesso");
        }
    }
}

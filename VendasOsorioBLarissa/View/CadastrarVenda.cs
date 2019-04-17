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
            ListarClientes.Renderizar();
            Console.WriteLine("Digite o CPF do cliente");
            c.Cpf = Console.ReadLine();

            c = ClienteDAO.BuscarClientePorCpf(c);
            if(c != null)
            {
                v.Cliente = c;
                //Funcionario
                ListarVendedor.Renderizar();
                Console.WriteLine("Digite o CPF do funcionário:");
                ven.Cpf = Console.ReadLine();
                ven = VendedorDAO.BuscarVendedorPorCpf(ven);
                if (ven!=null)
                {
                    v.Vendedor = ven;

                    //Adicionando itens na venda
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Adicionando itens \n");
                        //Incluir produto
                        p = new Produto();
                        ListarProduto.Renderizar();
                        Console.WriteLine("Digite o código do produto:");
                        p.Codigo = Convert.ToInt32(Console.ReadLine());
                        p = ProdutoDAO.BuscarProduto(p);
                        if (p != null)
                        {

                            ItemVenda item = new ItemVenda();
                            item.Produto = p;
                            item.Preco = p.Preco;
                            Console.WriteLine("Digite a quantidade:");
                            item.Quantidade = Convert.ToInt32(Console.ReadLine());
                            v.ItensVenda.Add(item);
                        }
                        else
                        {
                            Console.WriteLine("Produto não cadastrado");
                        }
                        p = null;
                        Console.WriteLine("\n Deseja incluir mais produtos? S/N");
                    } while(Console.ReadLine().ToUpper().Equals("S"));


                    v.Quantidade = 1;
                    v.DataVenda = DateTime.Now;
                    VendaDAO.CadastrarVenda(v);
                    Console.WriteLine("Venda cadastrada com sucesso!");

                }
                else
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

        //Chamar o metodo de busca
        //Guardar o retorno do metodo
        //Verificar o que retorna - se retornar nullo nao continua
        //objeto null: informa uma mensagem de erro
        //objeto preenchido: guarda objeto dentro da venda
    }
}

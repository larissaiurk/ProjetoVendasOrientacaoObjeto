﻿using System;
using System.Collections.Generic;
using VendasOsorioBLarissa.DAL;
using VendasOsorioBLarissa.Model;

namespace VendasOsorioBLarissa.View
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;

            //Dados.Inserir();

            int escolha = 0;
            do
            {
                //Limpar o console;
                Console.Clear();

                Console.WriteLine("*** MENU *** \n 1 - Cadastrar Cliente \n 2 - Listar Clientes \n 3 - Cadastrar Vendedor \n 4 - Listar Vendedores \n 5 - Cadastrar Produto "+
                    "\n 6 - Listar Produtos \n 7 - Registrar Venda \n 8 - Listar Vendas \n 9 - Listar Vendas por Cliente \n 0 - Sair");
                escolha = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (escolha)
                {
                    case 1:
                        CadastrarCliente.Renderizar();
                        break;
                    case 2:
                        ListarClientes.Renderizar();
                        break;
                    case 3:
                        CadastrarVendedor.Renderizar();
                        break;
                    case 4:
                        ListarVendedor.Renderizar();
                        break;
                    case 5:
                        CadastrarProduto.Renderizar();
                        break;
                    case 6:
                        ListarProduto.Renderizar();
                        break;
                    case 7:
                        CadastrarVenda.Renderizar();
                        break;
                    case 8:
                        //ListarVenda.Renderizar();
                        break;
                    case 9:
                        Cliente c = new Cliente();
                        Console.Write("Digite o CPF do cliente");
                        c.Cpf = Console.ReadLine();
                        ListarVenda.Renderizar(VendaDAO.BuscarVendasPorCpf(c));
                        break;
                    case 0:
                        Console.WriteLine("Gratidão, até mais!");
                        escolha = 0;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("\n Aperte uma tecla para continuar...");
                Console.ReadKey();
            } while (escolha !=0);



        }

       
    }
}

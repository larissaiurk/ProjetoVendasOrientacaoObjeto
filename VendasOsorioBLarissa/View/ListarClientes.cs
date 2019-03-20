﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasOsorioBLarissa.DAL;
using VendasOsorioBLarissa.Model;

namespace VendasOsorioBLarissa.View
{
    class ListarClientes
    {
        public static void Renderizar()
        {
            Console.WriteLine("Listar Clientes");

            foreach (Cliente clienteCadastrado in ClienteDAO.listarClientes())
            {
                Console.WriteLine(clienteCadastrado.ToString() + "\n");
            }
        }
    }
}

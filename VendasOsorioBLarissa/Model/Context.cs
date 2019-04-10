using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasOsorioBLarissa.Model
{
    /// <summary>
    /// Essa classe representa o banco de dados da aplicação
    /// e o EntityFramework
    /// </summary>
    class Context : DbContext
    {
        //renomear banco de dados
        public Context() : base("BancoVendas") { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<ItemVenda> ItensVenda { get; set; }
    }
}

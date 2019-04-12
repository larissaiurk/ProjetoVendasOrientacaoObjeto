namespace VendasOsorioBLarissa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cpf = c.String(),
                        CriadoEm = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Vendas",
                c => new
                    {
                        VendaId = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        DataVenda = c.DateTime(nullable: false),
                        CriadoEm = c.DateTime(nullable: false),
                        Cliente_ClienteId = c.Int(),
                        Vendedor_VendedorId = c.Int(),
                    })
                .PrimaryKey(t => t.VendaId)
                .ForeignKey("dbo.Clientes", t => t.Cliente_ClienteId)
                .ForeignKey("dbo.Vendedores", t => t.Vendedor_VendedorId)
                .Index(t => t.Cliente_ClienteId)
                .Index(t => t.Vendedor_VendedorId);
            
            CreateTable(
                "dbo.ItensVenda",
                c => new
                    {
                        ItemVendaId = c.Int(nullable: false, identity: true),
                        Quantidade = c.Double(nullable: false),
                        Preco = c.Double(nullable: false),
                        CriadoEm = c.DateTime(nullable: false),
                        Produto_ProdutoId = c.Int(),
                        Venda_VendaId = c.Int(),
                    })
                .PrimaryKey(t => t.ItemVendaId)
                .ForeignKey("dbo.Produtos", t => t.Produto_ProdutoId)
                .ForeignKey("dbo.Vendas", t => t.Venda_VendaId)
                .Index(t => t.Produto_ProdutoId)
                .Index(t => t.Venda_VendaId);
            
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        ProdutoId = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        Nome = c.String(),
                        Quantidade = c.Double(nullable: false),
                        Preco = c.Double(nullable: false),
                        CriadoEm = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ProdutoId);
            
            CreateTable(
                "dbo.Vendedores",
                c => new
                    {
                        VendedorId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cpf = c.String(),
                        CriadoEm = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.VendedorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vendas", "Vendedor_VendedorId", "dbo.Vendedores");
            DropForeignKey("dbo.ItensVenda", "Venda_VendaId", "dbo.Vendas");
            DropForeignKey("dbo.ItensVenda", "Produto_ProdutoId", "dbo.Produtos");
            DropForeignKey("dbo.Vendas", "Cliente_ClienteId", "dbo.Clientes");
            DropIndex("dbo.ItensVenda", new[] { "Venda_VendaId" });
            DropIndex("dbo.ItensVenda", new[] { "Produto_ProdutoId" });
            DropIndex("dbo.Vendas", new[] { "Vendedor_VendedorId" });
            DropIndex("dbo.Vendas", new[] { "Cliente_ClienteId" });
            DropTable("dbo.Vendedores");
            DropTable("dbo.Produtos");
            DropTable("dbo.ItensVenda");
            DropTable("dbo.Vendas");
            DropTable("dbo.Clientes");
        }
    }
}

namespace Edu.Infrastructure.Persistance.Contexts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        StreetAddress = c.String(),
                        PostalAddress_PostalAddressID = c.Int(),
                    })
                .PrimaryKey(t => t.CustomerID)
                .ForeignKey("dbo.PostalAddresses", t => t.PostalAddress_PostalAddressID)
                .Index(t => t.PostalAddress_PostalAddressID);
            
            CreateTable(
                "dbo.PostalAddresses",
                c => new
                    {
                        PostalAddressID = c.Int(nullable: false, identity: true),
                        PostCode = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.PostalAddressID);
            
            CreateTable(
                "dbo.SalesOrderItems",
                c => new
                    {
                        SalesOrderItemID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SalesOrder_SalesOrderID = c.Int(),
                    })
                .PrimaryKey(t => t.SalesOrderItemID)
                .ForeignKey("dbo.SalesOrders", t => t.SalesOrder_SalesOrderID)
                .Index(t => t.SalesOrder_SalesOrderID);
            
            CreateTable(
                "dbo.SalesOrders",
                c => new
                    {
                        SalesOrderID = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SalesOrderID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SalesOrderItems", "SalesOrder_SalesOrderID", "dbo.SalesOrders");
            DropForeignKey("dbo.Customers", "PostalAddress_PostalAddressID", "dbo.PostalAddresses");
            DropIndex("dbo.SalesOrderItems", new[] { "SalesOrder_SalesOrderID" });
            DropIndex("dbo.Customers", new[] { "PostalAddress_PostalAddressID" });
            DropTable("dbo.SalesOrders");
            DropTable("dbo.SalesOrderItems");
            DropTable("dbo.PostalAddresses");
            DropTable("dbo.Customers");
        }
    }
}

namespace Edu.Infrastructure.Persistance.Contexts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "FirstName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Customers", "LastName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Customers", "StreetAddress", c => c.String(maxLength: 30));
            AlterColumn("dbo.PostalAddresses", "PostCode", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.PostalAddresses", "City", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PostalAddresses", "City", c => c.String());
            AlterColumn("dbo.PostalAddresses", "PostCode", c => c.String());
            AlterColumn("dbo.Customers", "StreetAddress", c => c.String());
            AlterColumn("dbo.Customers", "LastName", c => c.String());
            AlterColumn("dbo.Customers", "FirstName", c => c.String());
        }
    }
}

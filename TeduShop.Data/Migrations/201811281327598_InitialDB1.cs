namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.MenuGruops", newName: "MenuGroups");
            AddColumn("dbo.OrderDetails", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Orders", "CustomerMobile", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Orders", "CustomerId", c => c.String(maxLength: 128));
            AddColumn("dbo.Products", "Tags", c => c.String());
            AddColumn("dbo.Products", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "OriginalPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Slides", "Content", c => c.String());
            AddColumn("dbo.SupportOnlines", "Department", c => c.String(maxLength: 50));
            AlterColumn("dbo.Orders", "CustomerMessage", c => c.String(nullable: false, maxLength: 256));
            AlterColumn("dbo.Posts", "HotFlag", c => c.Boolean());
            DropColumn("dbo.Orders", "CustomerMoble");
            DropColumn("dbo.SupportOnlines", "Deparment");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SupportOnlines", "Deparment", c => c.String(maxLength: 50));
            AddColumn("dbo.Orders", "CustomerMoble", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Posts", "HotFlag", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Orders", "CustomerMessage", c => c.String(nullable: false, maxLength: 250));
            DropColumn("dbo.SupportOnlines", "Department");
            DropColumn("dbo.Slides", "Content");
            DropColumn("dbo.Products", "OriginalPrice");
            DropColumn("dbo.Products", "Quantity");
            DropColumn("dbo.Products", "Tags");
            DropColumn("dbo.Orders", "CustomerId");
            DropColumn("dbo.Orders", "CustomerMobile");
            DropColumn("dbo.OrderDetails", "Price");
            RenameTable(name: "dbo.MenuGroups", newName: "MenuGruops");
        }
    }
}

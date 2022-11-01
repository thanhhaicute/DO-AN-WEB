namespace DOANCUOIKY.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewDB1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "Product_ProductID", "dbo.Products");
            DropIndex("dbo.Users", new[] { "Product_ProductID" });
            DropColumn("dbo.Users", "ProductID");
            DropColumn("dbo.Users", "Product_ProductID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Product_ProductID", c => c.Long());
            AddColumn("dbo.Users", "ProductID", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "Product_ProductID");
            AddForeignKey("dbo.Users", "Product_ProductID", "dbo.Products", "ProductID");
        }
    }
}

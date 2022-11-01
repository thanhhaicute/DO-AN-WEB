namespace DOANCUOIKY.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        BrandID = c.Long(nullable: false, identity: true),
                        BrandName = c.String(),
                    })
                .PrimaryKey(t => t.BrandID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Long(nullable: false, identity: true),
                        NameProduct = c.String(),
                        Price = c.Decimal(precision: 18, scale: 2),
                        Image1 = c.String(),
                        Image2 = c.String(),
                        Image3 = c.String(),
                        Amount = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        Sex = c.Int(nullable: false),
                        Describe = c.String(),
                        BrandID = c.Long(),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Brands", t => t.BrandID)
                .Index(t => t.BrandID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "BrandID", "dbo.Brands");
            DropIndex("dbo.Products", new[] { "BrandID" });
            DropTable("dbo.Products");
            DropTable("dbo.Brands");
        }
    }
}

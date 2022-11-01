namespace DOANCUOIKY.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        idBill = c.Int(nullable: false, identity: true),
                        InfoBill = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        idUser = c.Int(nullable: false),
                        idEmployer = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idBill)
                .ForeignKey("dbo.Employers", t => t.idEmployer, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.idUser, cascadeDelete: true)
                .Index(t => t.idUser)
                .Index(t => t.idEmployer);
            
            CreateTable(
                "dbo.Employers",
                c => new
                    {
                        idEmployer = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        typeEmployer = c.String(),
                    })
                .PrimaryKey(t => t.idEmployer);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        idUser = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        FullName = c.String(),
                        Email = c.String(),
                        Andreas = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        BirdDay = c.Int(nullable: false),
                        TypeCustomer = c.Int(nullable: false),
                        PromoCustomer = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        Product_ProductID = c.Long(),
                    })
                .PrimaryKey(t => t.idUser)
                .ForeignKey("dbo.Products", t => t.Product_ProductID)
                .Index(t => t.Product_ProductID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bills", "idUser", "dbo.Users");
            DropForeignKey("dbo.Users", "Product_ProductID", "dbo.Products");
            DropForeignKey("dbo.Bills", "idEmployer", "dbo.Employers");
            DropIndex("dbo.Users", new[] { "Product_ProductID" });
            DropIndex("dbo.Bills", new[] { "idEmployer" });
            DropIndex("dbo.Bills", new[] { "idUser" });
            DropTable("dbo.Users");
            DropTable("dbo.Employers");
            DropTable("dbo.Bills");
        }
    }
}

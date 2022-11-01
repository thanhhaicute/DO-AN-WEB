﻿namespace DOANCUOIKY.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Gia : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Price", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Price", c => c.Single());
        }
    }
}

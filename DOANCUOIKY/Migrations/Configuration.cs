namespace DOANCUOIKY.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DOANCUOIKY.Models.DatabaseConnect>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "DOANCUOIKY.Models.DatabaseConnect";
        }

        protected override void Seed(DOANCUOIKY.Models.DatabaseConnect context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}

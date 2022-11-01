using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DOANCUOIKY.Models
{
    public class DatabaseConnect : DbContext
    {

        public DatabaseConnect() : base("Database") { }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Bill> Bills { get; set; }

    }
}
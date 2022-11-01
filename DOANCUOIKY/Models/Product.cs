using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOANCUOIKY.Models
{
    public class Product
    {
        public long ProductID { get; set; }
        public string NameProduct { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public int Amount { get; set; }
        public int Type { get; set; }
        public int Sex { get; set; }

        public string Describe { get; set; }

        public string MaSP { get; set; }

        public DateTime Time { get; set; }

        public Nullable<long> BrandID { get; set; }

        public virtual Brand Brand { get; set; }
    }
}
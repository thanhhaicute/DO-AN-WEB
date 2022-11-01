using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DOANCUOIKY.Models
{
    public class Bill
    {
        [Key]
        public int idBill { get; set; }
        public string InfoBill { get; set; }
        public DateTime ReleaseDate { get; set; }

        public int idUser { get; set; }
        public int idEmployer { get; set; }

        public virtual User User { get; set; }
        public virtual Employer Employer { get; set; }

    }
}
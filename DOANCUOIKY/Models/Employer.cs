using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DOANCUOIKY.Models
{
    public class Employer
    {
        [Key]
        public int idEmployer { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string typeEmployer { get; set; }

    }
}
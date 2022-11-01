using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DOANCUOIKY.Models
{
    public class User
    {
        [Key]
        public int idUser { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Andreas { get; set; }
        public int PhoneNumber { get; set; }
        public int BirdDay { get; set; }
        public int TypeCustomer { get; set; }
        public int PromoCustomer { get; set; }




    }
}
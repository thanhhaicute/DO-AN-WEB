using DOANCUOIKY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOANCUOIKY.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        DatabaseConnect db = new DatabaseConnect();

        public ActionResult Index()
        {
            List<Product> products = db.Products.Where(row => row.Type == 2 ).ToList();
            return View(products);
        }
    }
}
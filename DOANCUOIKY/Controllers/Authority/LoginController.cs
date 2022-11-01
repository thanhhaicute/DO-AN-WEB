using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOANCUOIKY.Controllers.Authority
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index(string username, string password)
        {
            return View();
        }
    }
}
using DOANCUOIKY.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOANCUOIKY.Controllers.Admin
{
    public class AdminController : Controller
    {
        DatabaseConnect db = new DatabaseConnect();

        // GET: Admin
        public ActionResult Index()
        {
            ViewBag.Brand = db.Brands.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product p,HttpPostedFileBase Image1, HttpPostedFileBase Image2, HttpPostedFileBase Image3)

        {
            db.Products.Add(p);

            db.SaveChanges();

            if (Image1 != null && Image1.ContentLength > 0)
            {
                int id = int.Parse(db.Products.ToList().Last().ProductID.ToString());

                string _FileName = "";
                int index = Image1.FileName.IndexOf('.');
                _FileName = "nv" + id.ToString() + "." + Image1.FileName.Substring(index + 1);
                string _path = Path.Combine(Server.MapPath("~/Content/Images/products"), _FileName);
                Image1.SaveAs(_path);

                Product unv = db.Products.FirstOrDefault(x => x.ProductID == id);
                unv.Image1 = _FileName;
                db.SaveChanges();
            }

            if (Image2 != null && Image2.ContentLength > 0)
            {
                int id = int.Parse(db.Products.ToList().Last().ProductID.ToString());

                string _FileName = "";
                int index = Image2.FileName.IndexOf('.');
                _FileName = "nv" + id.ToString() + "." + Image2.FileName.Substring(index + 1);
                string _path = Path.Combine(Server.MapPath("~/Content/Images/products"), _FileName);
                Image2.SaveAs(_path);

                Product unv = db.Products.FirstOrDefault(x => x.ProductID == id);
                unv.Image2 = _FileName;
                db.SaveChanges();
            }
            if (Image3 != null && Image3.ContentLength > 0)
            {
                int id = int.Parse(db.Products.ToList().Last().ProductID.ToString());

                string _FileName = "";
                int index = Image3.FileName.IndexOf('.');
                _FileName = "nv" + id.ToString() + "." + Image3.FileName.Substring(index + 1);
                string _path = Path.Combine(Server.MapPath("~/Content/Images/products"), _FileName);
                Image3.SaveAs(_path);

                Product unv = db.Products.FirstOrDefault(x => x.ProductID == id);
                unv.Image3 = _FileName;
                db.SaveChanges();
            }
            return RedirectToAction("Index");

        }
    }
}
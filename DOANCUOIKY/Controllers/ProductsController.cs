using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DOANCUOIKY.Models;

namespace DOANCUOIKY.Controllers
{

    /*TYPE :
    1 : ÁO POLO
    2 : ÁO SƠ MI
    3 : ÁO PHÔNG
    4 : ÁO CADIGAN
    5 : ÁO HOODIE
    6 : ÁO JACKET
    7 : TÚI / BACKPACK
    8 : GIÀY
    9 : PHỤ KIỆN
    10 : QUẦN
    */
    public class ProductsController : Controller
    {

        DatabaseConnect db = new DatabaseConnect();
        // GET: Products
        public ActionResult Index(string search="", string SortColumn = "ProductID", int page = 0)
        {
            //List<products> products = db.products.ToList();

            //Tìm kiếm
            List<Product> products = db.Products.Where(row =>
                row.NameProduct.Contains(search)).ToList();
            ViewBag.Search = search;


            ///Sắp xếp
            ViewBag.SortColumn = SortColumn;
            if (SortColumn == "GiaTang")
            {
                products = products.OrderBy(row => row.Price).ToList();
            }
            if (SortColumn == "GiaGiam")
            {
                products = products.OrderByDescending(row => row.Price).ToList();
            }
            if (SortColumn == "AtoZ")
            {
                products = products.OrderBy(row => row.NameProduct).ToList();
            }
            if (SortColumn == "ZtoA")
            {
                products = products.OrderByDescending(row => row.NameProduct).ToList();
            }
            if (SortColumn == "AOSOMI")
            {
                products = products.Where(row => row.Type == 1).ToList();
            }
            if (SortColumn == "AOPOLO")
            {
                products = products.Where(row => row.Type == 2).ToList();
            }
            if (SortColumn == "DANHCHONAM")
            {
                products = products.Where(row => row.Sex == 1).ToList();
            }
            if (SortColumn == "DANHCHONU")
            {
                products = products.Where(row => row.Sex == 2).ToList();
            }


            ///Pageing
            ///

            int noOfRecordPerpage = 6;
            int noOfPages = Convert.ToInt32(Math.Ceiling
                (Convert.ToDouble(products.Count) / Convert.ToDouble(noOfRecordPerpage)));
            int ChuyenTrang = (page - 1) * noOfRecordPerpage;
            ViewBag.page = page;
            ViewBag.noOfPages = noOfPages;
            products = products.Skip(ChuyenTrang).Take(noOfRecordPerpage).ToList();



            return View(products);
        }
       
        public ActionResult Detail(int id)
        {
            Product detail = db.Products.Where(row => row.ProductID == id).FirstOrDefault();

            return View(detail);
        }
    }
}
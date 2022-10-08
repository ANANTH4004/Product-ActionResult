using MVC1.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        static List<ProdModel> Plist = new List<ProdModel>();
        static ProductController()
        {
            Plist.Add(new ProdModel { ProdID = 1, ProdName = "Pen", Price = 6, MgfDate= new DateTime(2020,03,20),ExpDate = new DateTime(2021,04,20)});
            Plist.Add(new ProdModel { ProdID = 2, ProdName = "Pencil", Price = 5, MgfDate= new DateTime(2000,03,20),ExpDate = new DateTime(2010,02,20)});
        }
        public ActionResult Index()
        {
            return View(Plist);
        }
        public ActionResult EditProd(int id)
        {
            ProdModel prod = Plist.Find(item=>item.ProdID == id);
            Plist.Remove(prod);
            return View(prod); 
        }
        [HttpPost]
        public ActionResult EditProd(ProdModel model)
        {
             Plist.Add(model);
            return RedirectToAction("Index");
        }
        public ActionResult DetailsProd(int id)
        {
            var data = Plist.Find(item => item.ProdID == id);
            return View(data);
        }
        public ActionResult CreateProd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateProd(ProdModel model)
        {
            Plist.Add(model);
            return RedirectToAction("Index");
        }
        public ActionResult Temp()
        {
            return View();
        }
    }
}
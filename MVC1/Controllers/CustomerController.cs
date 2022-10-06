using MVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        static List<CustModel> CustList = new List<CustModel>();
         static CustomerController()
        {
            CustList.Add(new CustModel { CustID = 23, CustName = "Bonda", City = "Chidambaram" });
        }
        public ActionResult Index()
        {
            return View(CustList);
        }
        public ActionResult AcceptData()
        {
            return View();
        }
        [HttpPost]  
        public ActionResult AcceptData(CustModel model)
        {
            return View(); 
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CustModel model)
        {
            CustList.Add(model);
            return RedirectToAction("Index");
        }
      
       
    }
}
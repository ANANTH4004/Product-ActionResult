using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Web.Mvc;
using MVC1.Models;
using RedirectResult = System.Web.Mvc.RedirectResult;
using ContentResult = System.Web.Mvc.ContentResult;
using FileResult = System.Web.Mvc.FileResult;
using RedirectToRouteResult = System.Web.Mvc.RedirectToRouteResult;
//using Microsoft.AspNetCore.Mvc;

namespace MVC1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public System.Web.Mvc.ActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return (IActionResult)View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return (IActionResult)View();
        }

        public IActionResult Privacy()
        {
            return (IActionResult)View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return (IActionResult)View();
        }

        public ContentResult StudentAsString()
        {
            return Content("The name of the student is Walter Smith and he is in Grade 7.");
        }

        public ViewResult StudentAsView()
        {
            ViewData["message"] = "The name of the student is <b>Walter Smith</b> and he is in Grade 7.";
            return View();
        }

        public RedirectResult StudentAsRedirectResult()
        {
            return new RedirectResult("https://www.bing.com/search?q=walter+smith");

        }
        public RedirectToRouteResult StudentAsRedirectToRouteResult()
        {
            return  RedirectToRouteResult();
        }

        private RedirectToRouteResult RedirectToRouteResult()
        {
            throw new NotImplementedException();
        }

        public FileResult StudentAsFileResult()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(@"./wwwroot/StudentData.txt");
            string fileName = "StudentData.txt";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }
        public JsonResult StudentAsJSONResult()
        {
            String data = System.IO.File.ReadAllText(@"./wwwroot/StudentData.json");
            JObject json = JObject.Parse(data);
            return Json(json);
        }
        public ViewResult StudentList()
        {
            return View();
        }


    }
}
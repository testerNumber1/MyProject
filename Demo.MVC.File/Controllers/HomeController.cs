using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo.MVC.File.Models;
namespace Demo.MVC.File.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult UpFile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpFile(Person model)
        {
            HttpPostedFileBase file = HttpContext.Request.Files["file"];
            string b = "Image/" + file.FileName;
            string c =Server.MapPath(b);
            file.SaveAs(c);
            return View();
        }
    }
}
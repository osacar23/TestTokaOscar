using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestToka.Data;
using TestToka.Data.Core;
using TestToka.Data.Entities;

namespace TestToka.WebApi.Controllers
{
   
    public class HomeController : Controller
    {
               
        public ActionResult Index()
        {            
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
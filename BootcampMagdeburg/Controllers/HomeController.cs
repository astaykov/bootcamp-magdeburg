using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootcampBerlin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            System.Diagnostics.Trace.WriteLine("Home :: Index");
            return View();
        }

        public ActionResult Speakers()
        {
            System.Diagnostics.Trace.WriteLine("Home :: Speakers");
            return View();
        }

        public ActionResult Contact()
        {

            System.Diagnostics.Trace.WriteLine("Home :: Contact");

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
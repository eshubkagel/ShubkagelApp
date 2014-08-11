using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

using ShubkagelApp;
namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.GKey = "AIzaSyB1PwaN07ox0oOxoQ3dP7OHbLhYFMPVgfQ";
            return View("Index");
        }

     
    }
}

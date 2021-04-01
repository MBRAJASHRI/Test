using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
          <!-- helo changes Test Branch-->
            ViewBag.Title = "Home Page Home page";

            return View();
        }
    }
}

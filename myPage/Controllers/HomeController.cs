using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myPage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewBag.identification = "Wiliam Kern Franco - Developer";
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
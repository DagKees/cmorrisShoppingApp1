using cmorrisShoppingApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cmorrisShoppingApp1.Controllers
{
    public class HomeController : Universal
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Popup()
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
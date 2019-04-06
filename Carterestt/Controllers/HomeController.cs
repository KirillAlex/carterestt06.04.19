using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carterestt.Controllers
{
    public class HomeController : Controller
    {
        private CarContext db = new CarContext();

        public ActionResult Index()
        {

            return View(db.Brands.ToList());
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
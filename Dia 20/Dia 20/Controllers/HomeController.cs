using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dia_20.Controllers
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

        public ActionResult Calculator()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Persona persona)
        {
            if (ModelState.IsValid)
            {
                //create
            }
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}
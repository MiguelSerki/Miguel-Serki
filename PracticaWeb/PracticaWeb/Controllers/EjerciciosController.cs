using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaWeb.Controllers
{
    public class EjerciciosController : Controller
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
        public ActionResult Ejercicio1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ejercicio1(int a, int b, int c)
        {
            ViewBag.Message = "Crear 3 variables numéricas con el valor que tú quieras y en otra variable numérica guardar el valor de la suma de las 3 anteriores. Mostrar por consola.";
            ViewBag.k = a + b + c;
            return View();
        }

        public ActionResult Ejercicio2()
        {
            ViewBag.msg = "";
            return View();
        }
        [HttpPost]
        public ActionResult Ejercicio2(string nombre, string ciudad)
        {
            ViewBag.msg = $"Aloha {nombre}! Tu ciudad es {ciudad}";
            return View();
        }
    }
}
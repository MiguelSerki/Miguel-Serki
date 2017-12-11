using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services;
using Services.DTO;

namespace WebNoticias.Controllers
{
    public class UserController : Controller
    {
        private Service Services = new Service();

        // GET: User
        public ActionResult Index()
        {
            var list = this.Services.ShowAllUsers();
            return View(list);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        [HttpPost]
        public ActionResult Create(UserDTO user)
        {
            try
            {
                this.Services.PushUserToDB(user);
                ViewBag.msg = "Su usuario ha sido creado con exito!";
            }
            catch (Exception e)
            {
                ViewBag.msg = "Hubo un error creando su usuario. Queme a los programadores";

            }

            return View();
        }

        public ActionResult Create()
        {

            return View();
        }

        // GET: User/Update
        public ActionResult Update()
        {
            return View();
        }

        // POST: User/Update
        [HttpPost]
        public ActionResult Update(string name)
        {
           ViewBag.msg = this.Services.UpdateUser(name);
            return RedirectToAction("/Update");
        }

        // GET: User/Delete/5
        public ActionResult Delete()
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(string name)
        {
            ViewBag.msg = this.Services.DeleteUser(name);
            return RedirectToAction("/Delete");
        }


    }
}

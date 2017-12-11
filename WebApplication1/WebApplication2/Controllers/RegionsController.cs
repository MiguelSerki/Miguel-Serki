using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class RegionsController : Controller
    {
        // GET: Regions
        public ActionResult Index()
        {
            List<Region> regions;
            using (var context = new EntityDataModel())
            {
                regions = context.Region.ToList();
            }
            return View(regions);
        }

        // GET: Regions/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Regions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Regions/Create
        [HttpPost]
        public ActionResult Create(Region region)
        {


            using (var context = new EntityDataModel())
            {
                Region x = new Region()
                {
                    RegionDescription = "Aloha",
                    RegionID = (context.Region.Count()+1)
            };
                context.Region.Add(x);
                context.SaveChanges();
            }  
                return View();

        }

        // GET: Regions/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Regions/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Regions/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Regions/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

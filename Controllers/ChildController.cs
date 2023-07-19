using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMvc.Controllers
{
    public class ChildController : Controller
    {
        // GET: Child
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult RenderList(List<string> renderTypes )  
        {
            return View(renderTypes);            
        }

        public ActionResult MyRendering()
        {
            return Content("This is My Rendering from Child Controller.");
        }

        public ActionResult MyReturning(int id)
        {
            var MyCollection = new[]
            {
               new{ id = 1 , Name="Html.RenderPartial123" },
               new{ id = 2 , Name="Html.RenderAction" },
               new{ id = 3 , Name="Html.Partial" },
               new{ id = 4 , Name="Html.Action" },
            };
            return Content(MyCollection.Where(x => x.id == id).FirstOrDefault().Name);
        }


        // GET: Child/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Child/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Child/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Child/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Child/Edit/5
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

        // GET: Child/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Child/Delete/5
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

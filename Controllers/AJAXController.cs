using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMvc.Models;

namespace WebMvc.Controllers
{
    public class AJAXController : Controller
    {
        PracticeEntities db = new PracticeEntities();
        // GET: AJAX
        public ActionResult Index()
        {
            return View();
        }


        public PartialViewResult ALL()
        {
            bool? isfalse = null;
            if (Request.IsAjaxRequest())
                isfalse = true;
            var student = db.tblEmployees.ToList();
            return PartialView("_PartialEmployee", student);
        }

        public PartialViewResult Top5() 
        {
            var student = db.tblEmployees.OrderByDescending(x => x.Name).Take(5).ToList();
            return PartialView("_PartialEmployee", student);
        }
        public PartialViewResult Bottom5() 
        {
            var student = db.tblEmployees.OrderBy(x => x.Name).Take(5).ToList();
            return PartialView("_PartialEmployee", student);
        }
    }
}
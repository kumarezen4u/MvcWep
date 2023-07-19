using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMvc.Controllers
{
    public class ActionResultTypesController : Controller
    {
        // GET: ActionResultTypes
        public ActionResult Index()
        {
            return View();
        }


        public ViewResult Type1() 
        {
            return View();
        }
    }
}
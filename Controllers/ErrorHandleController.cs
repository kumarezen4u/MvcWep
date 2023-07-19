using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMvc.Controllers
{
    public class ErrorHandleController : Controller
    {
        // GET: ErrorHandle
       [HandleError(ExceptionType =typeof(ArithmeticException),View = "ErrorView01")]
        public ActionResult Index()
        {

          //  throw new ArithmeticException("Some thing went wrong");
            //ViewBag.Message = "Welcome to ASP.NET MVC!";
            //int u = Convert.ToInt32(""); // Error line  
           return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public string Index(string comments)
        {
            return "your Entered " + comments;
        }

    }
}
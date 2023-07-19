using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace WebMvc.Controllers
{
    public class ErrorController : Controller
    {
        [System.Web.Mvc.Route("error/found")]
        public ActionResult NotFound()
        {
            int i = 6, j = 0;
            int res = i / j;

            return View();
        }

       
    }
}

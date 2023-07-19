using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebMvc.Controllers
{
    public class CommonController : Controller
    {

        [HttpPost]        
        public async Task<JsonResult> GetData()
        {
            string indianTime = ""; 
            string newyorkTime = "";
            string londonTime = "";
            var taskRes = await Task.Run(async () =>
            {
            
                await Task.Delay(100);
                var timeUtc = DateTime.UtcNow;
                TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
                TimeZoneInfo britishZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
                newyorkTime = string.Format("US {0:HH:mm:ss tt}", TimeZoneInfo.ConvertTimeFromUtc(timeUtc, easternZone));
                londonTime = string.Format("London {0:HH:mm:ss tt}", TimeZoneInfo.ConvertTimeFromUtc(timeUtc, britishZone));
                indianTime =  string.Format("India  {0:HH:mm:ss tt}", DateTime.Now);
                return Json(indianTime +"!"+ newyorkTime + "!" + londonTime, JsonRequestBehavior.AllowGet);
            });
            return taskRes;
        }
        [Route("abc/common/page")]
        public ActionResult PageTitle(string pageTitle) 
        {
            ViewBag.PageTitle = "Hi Welcome";
            return View();
        }
        [Route("abc/common/other{customerName=RAJA")]
        public ActionResult OtherTest(string customerName)
        {
            ViewBag.Message = "Welcome to ASP.NET MVC : "+ customerName;
            return View();
        }

    }
}

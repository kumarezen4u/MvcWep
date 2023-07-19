using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Security;
using WebMvc.BAL;

namespace WebMvc.Controllers
{
    public class SecurityController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult CheckUser(Users users)
        {
            if ((users.Username== "kumar") && (users .Password == "kumar"))
            {
                //use formsauthentication class to set the cookie
                FormsAuthentication.SetAuthCookie(users.Username, true);
                //redirect to About view
             
                return RedirectToAction("Index","Home");
            }
            else
            {
                return View("Login");
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebMvc.BAL;
using WebMvc.Models;
using System.Net.Http;
using WebMvc.FileLogger;
using System.Web.Security;

namespace WebMvc.Controllers
{
    public class HomeController : Controller
    {   
        [HttpGet]       
        public ActionResult Index()
        {
            HttpCookie AuthCookie= FormsAuthentication.GetAuthCookie("Username1",true);
            return View(this.GetEmployeeModel(1));
        }
        [HttpPost]
        public ActionResult Index(int currentPageIndex)
        {
            return View(this.GetEmployeeModel(currentPageIndex));
        }

        public EmployeeModel GetEmployeeModel(int currentPage) 
        {
            int maxRows = 5;
            EmployeeModel objEmployee = new EmployeeModel();
            Emp objemp = new Emp();
            objEmployee.Employes = (from emp in objemp.GetEmps() select emp).OrderBy(x => x.EmpId)
                                   .Skip((currentPage - 1) * maxRows)
                                   .Take(maxRows).ToList();
            double pageCount = (double)((decimal)objemp.GetEmps().Count() / Convert.ToDecimal(maxRows));
            objEmployee.PageCount = (int)Math.Ceiling(pageCount);
            objEmployee.CurrentPageIndex = currentPage;
            objEmployee.TotalRecords = objemp.GetEmps().Count();
            return objEmployee;
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            LogHelper.Info("Controller : Home - Action Method : About executed.");
            return View();
        }
        [HttpPost]
        public ActionResult About(LoginViewModel model)
        {          

            ViewBag.Message = "Your application description page.";
            if (!ModelState.IsValid) return View(model);

            Tokeninfo tokeninfo = new Tokeninfo();
            if (!GetAUthenticate(model ,ref tokeninfo))
            {
                ModelState.AddModelError("Username", "The user name or password is incorrect");
                HttpCookie reqCookies = Request.Cookies["userInfo"];
                LogHelper.Info("The user name or password is incorrect", (object)reqCookies.Name);
                return View(model);
            }
            else
            {
                HttpCookie userInfo = new HttpCookie("userInfo");
                userInfo["UserName"] = model.Username;
                userInfo["UserRole"] = tokeninfo.UserInfo;
                userInfo["token"] = tokeninfo.AccessToken;
                userInfo["expires_in"] = tokeninfo.ExpiresIn.ToString();
                int expire = Convert.ToInt32(tokeninfo.ExpiresIn);
                TimeSpan time = new TimeSpan(0, 0, expire, 0);
                userInfo["expireDate"] = DateTime.Now.Add(time).ToLongDateString();
                Response.Cookies.Add(userInfo);

               return RedirectToAction("EmpIndex", "EmployeeInfo");
                //return Redirect("Employee/Index");
            }          
        }
        




        public static bool GetAUthenticate(LoginViewModel model,ref Tokeninfo tokeninfo)
        {
            string apiUrl = "http://localhost:61695/token";

            bool res = false;

            using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
            {
                var values = new Dictionary<string, string>();
                values.Add("username", model.Username);
                values.Add("password", model.Password);
                values.Add("grant_type", "password");
                var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(values);
                var response =  client.PostAsync(apiUrl,new FormUrlEncodedContent(values)).Result;
                var result = response.Content.ReadAsAsync<Tokeninfo>(new[] { new System.Net.Http.Formatting.JsonMediaTypeFormatter() }).Result;

                if (response.IsSuccessStatusCode  && result.Error ==null)
                {
                    var data =  response.Content.ReadAsStringAsync();
                    res = true;
                    tokeninfo = result;
                    // var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);
                }
                else
                {
                    res = false;
                }
            }

            return res;
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }     

    }
    public class Tokeninfo 
    {
        [Newtonsoft.Json.JsonProperty("access_token")]
        public string AccessToken { get; set; }
        [Newtonsoft.Json.JsonProperty("token_type")]
        public string TokenType { get; set; }
        [Newtonsoft.Json.JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }
        [Newtonsoft.Json.JsonProperty("userInfo")]
        public string UserInfo { get; set; }
        [Newtonsoft.Json.JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
        [Newtonsoft.Json.JsonProperty("error")]
        public string Error { get; set; }
    }

   
}
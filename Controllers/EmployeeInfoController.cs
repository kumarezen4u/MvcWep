using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMvc.Filters;
using WebMvc.Models;

namespace WebMvc.Controllers
{
   
    public class EmployeeInfoController : Controller
    {
        // GET: Employee
        [SessionExpireFilter]
        [MyResultfilter]
        public ActionResult EmpIndex() 
        {
            List<EmployeeInfoModel> employeeModel = new List<EmployeeInfoModel>();           
                string apiUrl = "http://localhost:61695/api/Employee/GetEmployees";
                using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
                {
                    HttpCookie reqCookies = Request.Cookies["userInfo"];
                    client.BaseAddress = new Uri(apiUrl);
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", reqCookies["token"].ToString());
                    System.Net.Http.HttpResponseMessage response = client.GetAsync(apiUrl).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        System.Console.WriteLine("Success");
                        employeeModel = JsonConvert.DeserializeObject<List<EmployeeInfoModel>>(response.Content.ReadAsStringAsync().Result);
                    }
                    else
                    {
                        string responseBody = response.Content.ReadAsStringAsync().Result;
                        var JSONObj = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseBody);
                    throw new HttpException((int)response.StatusCode, JSONObj["Message"]);
                    }
                }
          
          
                return View(employeeModel);
        }
    }
}
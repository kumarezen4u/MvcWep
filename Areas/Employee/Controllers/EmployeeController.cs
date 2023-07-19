using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMvc.BAL;

namespace WebMvc.Areas.Employee.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
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

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}
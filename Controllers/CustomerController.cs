using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using WebMvc.BAL;
using WebMvc.Filters;
using WebMvc.Models;
namespace WebMvc.Controllers
{
    //[LogAttribute]
    public class CustomerController : Controller
    {
        //
        public ActionResult Index()
        {
            CustomerModel customerModel = new CustomerModel();
            return View(this.GetCustomerModel(1)); 
        }
        [HttpPost]
         [LogAttribute]
        public ActionResult Index(int currentPageIndex)
        {           
            return View(this.GetCustomerModel(currentPageIndex));
        }
        public CustomerModel GetCustomerModel(int currentPage) 
        {
            MyDbContext myDbContext = new MyDbContext();
            int maxRows = 10;
            CustomerModel objCustomerModel = new CustomerModel();
            objCustomerModel.customerList = (from emp in myDbContext.customers select emp).OrderBy(x => x.CustomerID)
                                   .Skip((currentPage - 1) * maxRows)
                                   .Take(maxRows).ToList();
            double pageCount = (double)((decimal)myDbContext.customers.Count() / Convert.ToDecimal(maxRows));
            objCustomerModel.PageCount = (int)Math.Ceiling(pageCount);
            objCustomerModel.CurrentPageIndex = currentPage;
            objCustomerModel.TotalRecords = myDbContext.customers.Count();
            return objCustomerModel;
        }
    }
}

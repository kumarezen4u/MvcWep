using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMvc.Areas.Employee.Models;

namespace WebMvc.Areas.Employee.Controllers
{
    public class EMIController : Controller
    {
        // GET: Employee/EMI
        public ActionResult Emi()  
        {
            return View();
        }

        [HttpPost]
        public ActionResult Emi(EmiModel emiModel)
        {
            EMIDetails eMIDetails = new EMIDetails();
            List<EmiTable> emitable = eMIDetails.GetEmiTable(emiModel.PrincipalAmount, emiModel.InterestRate, emiModel.tenure, emiModel.EmiDate);
            EmiModel objModel = new EmiModel();
            if (emitable != null && emitable.Count > 0)
                objModel.EmiList = emitable;
            return View(objModel);
        }
    }
}

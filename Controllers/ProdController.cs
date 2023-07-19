using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMvc.Controllers
{
    public class ProdController : Controller
    {
        // GET: Prod
        public ActionResult Index()
        {
            return View();
        }


        //  GetProductGridData


        public JsonResult GetProductGridData(string UIDesc, string TypeDes, int rows = 50, int page = 1, string sidx = "", string sord = "")
        {

            //List<OrderTypes> lstOrderTypes = new List<OrderTypes>();
            //List<OrderType> lstOrderType = new List<OrderType>();
              var  result = GetPoducts();


            //if (lstOrderTypes.Count > 0)
            //{
            //    logger.Info("lstOrderTypes.Count- " + lstOrderTypes.Count);
            //    foreach (var order in lstOrderTypes)
            //    {
            //        lstOrderType.Add(new OrderType()
            //        {
            //            OrderTypeID = order.OrderTypeID,
            //            TypeName = order.TypeName,
            //            UserID = order.UserID,
            //            User = ((order.User != null) ? order.User : ""),
            //            FeedUserName = order.FeedUserName,
            //            IsUserFeed = order.IsUserFeed,
            //            OriginatingSystem = order.OriginatingSystem,
            //            IsInactive = order.IsInactive,
            //            InactiveDate = order.InactiveDate,
            //        });
            //    }
            //}

            //int pageIndex = Convert.ToInt32(page) - 1;
            //int pageSize = rows;
            int totalRecords = 77;
            //int totalRecords = lstOrderTypes.Count();
            //logger.Info("totalRecords- " + totalRecords);
            int totalPages = 11;
            //int totalPages = (int)Math.Ceiling((float)totalRecords / (float)pageSize);

            ////var result = lstOrderType.OfType<OrderType>().Where(s => s.OrderTypeID != 0).Skip(pageIndex * pageSize).Take(pageSize)
            ////    .OrderByDescending(s => s.TypeName).ToList();
            //var result = lstOrderType.OfType<OrderType>().Where(s => s.OrderTypeID != 0).OrderByDescending(s => s.TypeName).ToList();

            //logger.Info("sidx- " + sidx);

            //switch (sidx)
            //{
            //    case "UIDesc":
            //        result = (sord == "asc" ? result.OrderBy(s => s.TypeName) : result.OrderByDescending(s => s.TypeName)).ToList();
            //        break;
            //    case "TypeName":
            //        result = (sord == "asc" ? result.OrderBy(s => s.TypeName) : result.OrderByDescending(s => s.TypeName)).ToList();
            //        break;
            //    case "User":
            //        result = (sord == "asc" ? result.OrderBy(s => s.User) : result.OrderByDescending(s => s.User)).ToList();
            //        break;
            //    case "FeedUserName":
            //        result = (sord == "asc" ? result.OrderBy(s => s.FeedUserName) : result.OrderByDescending(s => s.FeedUserName)).ToList();
            //        break;
            //    case "OriginatingSystem":
            //        result = (sord == "asc" ? result.OrderBy(s => s.OriginatingSystem) : result.OrderByDescending(s => s.OriginatingSystem)).ToList();
            //        break;
            //    case "InactiveDate":
            //        result = (sord == "asc" ? result.OrderBy(s => s.InactiveDate) : result.OrderByDescending(s => s.InactiveDate)).ToList();
            //        break;
            //        //case "UserInfo":
            //        //    result = (sord == "asc" ? result.OrderBy(s => s.UserInfo) : result.OrderByDescending(s => s.UserInfo)).ToList();
            //        //    break;
            //        //case "UploadedBy":
            //        //    result = (sord == "asc" ? result.OrderBy(s => s.UploadedBy) : result.OrderByDescending(s => s.UploadedBy)).ToList();
            //        //    break;
            //        //case "UploadDate":
            //        //    result = (sord == "asc" ? result.OrderBy(s => s.UploadDate) : result.OrderByDescending(s => s.UploadDate)).ToList();
            //        //    break;

            //}
            //result = result.Where(s => s.OrderTypeID != 0).Skip(pageIndex * pageSize).Take(pageSize).ToList();

            var jsonData = new
            {
                total = totalPages,
                page,
                records = totalRecords,
                rows = (
                    from x in result
                    select new
                    {
                        i = x.ProductId,
                        cell = new string[] {
                                               x.ProductId.ToString(),
                                               x.ProductName.ToString(),
                                               x.UnitPrice.ToString(),
                                               x.UnitsInStock.ToString()
                        }
                    }).ToArray()
            };

            return Json(jsonData, JsonRequestBehavior.AllowGet);

        }


        public List<Prod> GetPoducts() 
        {
            List<Prod> prods = null;
            try
            {
              //  prods = dbContext.Database.SqlQuery<Prod>("[dbo].[usp_GetOrderTypes]").ToList();
            }
            catch (Exception ex){ }
            return prods;
        }
    }


    public class Prod 
    {
        public long ProductId { get; set; }      
        public string ProductName { get; set; }
        public string UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}


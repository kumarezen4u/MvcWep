using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using WebMvc.BAL;

namespace WebMvc.Controllers
{
    public class ProductController : Controller
    {
        //OutputCacheAttribute is used to cache the content returned by a controller action method,
        // So that the same content dose not need to be generated each and every time
        //  the same controller action is invoked
        //The output of the Index() action method will be cached for 10 seconds
        [OutputCache(Duration =10)]  
        //[CutormPartialCache("1MinuteCache")]
        public ActionResult Index()
        {            
            return View(this.GetProductModel(1));
        }
        [HttpPost]
        public ActionResult Index(int currentPageIndex)
        {
            return View(this.GetProductModel(currentPageIndex));
        }

        public ProductModel GetProductModel(int currentPage) 
        {
            int maxRows = 10;
            MyDbContext db = new MyDbContext();
            ProductModel objproduct = new ProductModel();
            objproduct.Products = (from pro in db.products select pro).OrderBy(x => x.ProductName)
                                   .Skip((currentPage - 1) * maxRows)
                                   .Take(maxRows).ToList();
            double pageCount = (double)((decimal)db.products.Count() / Convert.ToDecimal(maxRows));
            objproduct.PageCount = (int)Math.Ceiling(pageCount);
            objproduct.CurrentPageIndex = currentPage;
            objproduct.TotalRecords = db.products.Count();
            return objproduct;
        }
        //Child actions can be used to implement partial caching although not necessary
        //In this case, even if the ChildActionOnly attribute is removed a  portion of the view is cached as expected
        //[OutputCache(Duration =10)]
        //[OutputCache(CacheProfile = "1MinuteCache")]
        [CutormPartialCache("1MinuteCache")]
        [ChildActionOnly]
        public string GetProductCount()
        {
            MyDbContext db = new MyDbContext();
            return "Product Count :"+ db.products.Count().ToString() +" " + DateTime.Now.ToString();
        }
       // To overcome these disadvantage, cache settings an be specified in web.config file using cache profiles

        //<caching><outputCacheSettings><outputCacheProfiles><clear />
        //<add name = "1MinuteCache" duration="60" varyByParam="none" />
        //</outputCacheProfiles></outputCacheSettings></caching>

        //To Make cache profiles work with child action methods, create a custom Out attribute 
        //public class CutormPartialCacheAttribute : OutputCacheAttribute
        //{
        //    public CutormPartialCacheAttribute(string cacheProfileName)
        //    {
        //        OutputCacheSettingsSection cacheSettings = (OutputCacheSettingsSection)
        //        WebConfigurationManager.GetSection("system.web/caching/outputCacheSettings");
        //        OutputCacheProfile cacheProfile = cacheSettings.OutputCacheProfiles[cacheProfileName];
        //        Duration = cacheProfile.Duration;
        //        VaryByParam = cacheProfile.VaryByParam;
        //        VaryByCustom = cacheProfile.VaryByCustom;
        //    }

        //}

    }
}

 //UnitsOnOrder    ReorderLevel Discontinued
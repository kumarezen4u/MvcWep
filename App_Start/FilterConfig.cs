using System.Web;
using System.Web.Mvc;
using WebMvc.Filters;

namespace WebMvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new LogAttribute());
            filters.Add(new HandleErrorAttribute());         
        }
    }
}

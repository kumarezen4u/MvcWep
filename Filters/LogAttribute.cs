using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using WebMvc.FileLogger;

namespace WebMvc.Filters
{
    public class LogAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Trace("OnActionExecuting", filterContext.RouteData);
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Trace("OnActionExecuted", filterContext.RouteData);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Trace("OnResultExecuting", filterContext.RouteData);
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Trace("OnResultExecuted", filterContext.RouteData);
        }


        private void Trace(string methodName, System.Web.Routing.RouteData routeData)
        {
            string controllerName = routeData.Values["controller"].ToString();
            string actionMethodName = routeData.Values["action"].ToString();
            HttpContext.Current.Response.Write($"MethodName={methodName},Controller={controllerName},Action Method={actionMethodName}");


        }
    }



    public class CustomExceptionFilter : IExceptionFilter   
    {
        public void OnException(ExceptionContext filtercontext)
        {
            string actionName = "Action=" + (string)filtercontext.RouteData.Values["action"] + " ; Controller = " + (string)filtercontext.RouteData.Values["controller"];
            string exceptionMessage = filtercontext.Exception.Message;
            LogHelper.Info($" ExceptionFilter :- CustomExceptionFilter :- OnException :  - {actionName}  :  {exceptionMessage}");
        }
    }

    public class SessionExpireFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string vl = string.Empty;
            HttpContext context = HttpContext.Current;
            HttpCookie reqCookies = context.Request.Cookies["userInfo"];           
              DateTime expire  =Convert.ToDateTime(reqCookies["expireDate"]);
              int res = DateTime.Compare(DateTime.Now, expire);
                if (res > 0)
                vl = res.ToString();

            string actionName = "Action=" + (string)filterContext.RouteData.Values["action"] + " ; Controller = " + (string)filterContext.RouteData.Values["controller"];
            LogHelper.Info($" ActionFilter :- SessionExpireFilter :- OnActionExecuting :  - {actionName} ");
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
        }
    }

    public class MyResultfilter : FilterAttribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            string actionName = "Action=" + (string)filterContext.RouteData.Values["action"] + " ; Controller = " + (string)filterContext.RouteData.Values["controller"];
            LogHelper.Info($" Result :- MyResultfilter :- OnResultExecuted :  - {actionName} ");
        }
        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            string actionName = "Action=" + (string)filterContext.RouteData.Values["action"] + " ; Controller = " + (string)filterContext.RouteData.Values["controller"];
            LogHelper.Info($" Result :- MyResultfilter :- OnResultExecuting :  - {actionName} ");
        }
    }

}
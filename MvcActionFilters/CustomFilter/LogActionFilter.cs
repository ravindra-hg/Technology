using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcActionFilters.CustomFilter
{
    public class LogActionFilter : ActionFilterAttribute
    {
        public LogActionFilter():base()
        {
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            this.Log("OnActionExecuting", filterContext.RouteData);
            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            this.Log("OnActionExecuted", filterContext.RouteData);
            base.OnActionExecuted(filterContext);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            this.Log("OnResultExecuting", filterContext.RouteData);
            base.OnResultExecuting(filterContext);
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            this.Log("OnResultExecuted", filterContext.RouteData);
            base.OnResultExecuted(filterContext);
        }

        private void Log(string p, System.Web.Routing.RouteData routeData)
        {
            Debug.WriteLine(string.Format("{0} - Controller:{1} - Action:{2} ", p, routeData.Values["controller"], routeData.Values["action"]));
        }

    }
}
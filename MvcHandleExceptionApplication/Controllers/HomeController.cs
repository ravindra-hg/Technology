using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcHandleExceptionApplication.Models;

namespace MvcHandleExceptionApplication.Controllers
{
    [HandleError()]
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View(new Employee()
            {
                Id = DateTime.Now.GetHashCode(),
                Name = "Raveendra",
                HomeAddress = new Address() { Line1 = "Address line 1", Line2 = "Address Line 2", Pincode = "560078" }
            });
        }

        public ActionResult StockmarketDashBoard(string type)
        {
            if (string.IsNullOrEmpty(type))
                throw new Exception("must have type");

            return View(new List<SecurityData>() { new SecurityData() { IndexName = "NSE", Name = "TSS", CurrentPrice = 120.00m } });
        }

        //protected override void OnException(ExceptionContext filterContext)
        //{
        //    var exception = filterContext.Exception;
        //    filterContext.ExceptionHandled = true;
        //    filterContext.Result = new ViewResult()
        //    {
        //         ViewName = "Error"
        //    };
        //}
    }
}
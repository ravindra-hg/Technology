using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcActionFilters.CustomFilter;

namespace MvcActionFilters.Controllers
{
    [LogActionFilter()]
    public class LogActionFilterController : Controller
    {
        //
        // GET: /LogActionFilter/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

    }
}

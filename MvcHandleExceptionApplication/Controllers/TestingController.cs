using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcHandleExceptionApplication.Controllers
{
    public class TestingController : Controller
    {
        //
        // GET: /Testing/

        public ActionResult NotFound()
        {
            return View();
        }

    }
}

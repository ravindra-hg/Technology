using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcPartialView.Models;

namespace MvcPartialView.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Product 1", Location = "J P Nagar" } ,
                new Product() { Id = 2, Name = "Product 2", Location = "Jayanagar" } 
            };
            return View(products);
        }

        public ActionResult _Product()
        {
            return View(new Client() { Name = "Client One", Location = "Client Location" });
        }

    }
}

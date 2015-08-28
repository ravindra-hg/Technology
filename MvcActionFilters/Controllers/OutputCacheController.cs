using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcActionFilters.Controllers
{
    public class OutputCacheController : Controller
    {
        //
        // GET: /OutputCache/
        /// <summary>
        /// This is to display datetime from cache
        /// </summary>
        /// <returns></returns>
        [OutputCache(CacheProfile="CacheMasterData")]
        public string Index()
        {
            string dateTime = DateTime.Now.ToString("T");
            return dateTime;
        }

    }
}

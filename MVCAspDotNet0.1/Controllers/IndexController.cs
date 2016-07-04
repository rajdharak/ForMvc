using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAspDotNet0._1.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            ViewBag.Countries = new List<string>()
            {
                "India",
                "usa",
                "pakistan"
        };
            ViewData["Countries"] = new List<string>()
            {
                "India",
                "usa",
                "pakistan"
        };
            return View();
        }
        
    }
}
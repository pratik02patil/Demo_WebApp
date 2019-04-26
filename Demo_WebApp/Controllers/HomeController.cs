using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Demo_WebApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}

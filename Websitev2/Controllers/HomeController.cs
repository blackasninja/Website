using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Websitev2.Controllers
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

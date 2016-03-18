

using System.Web.Mvc;

namespace CustomSiteV2.Controllers
{
    public class HomeController : Controller
    {
        [Route("home")]
        public ActionResult Home()
        {
            return View();
        }
    }
}

using System.Web.Mvc;

namespace CustomSite_V2.Controllers
{
    [RoutePrefix("")]
    public class HomeController : Controller
    {
        // GET: Home
        [Route("home")]
        public ActionResult Index()
        {
            return this.View();
        }
    }
}
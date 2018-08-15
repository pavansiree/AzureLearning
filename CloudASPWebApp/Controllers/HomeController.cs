using CloudASPWebApp.App_Start;
using System.Web.Mvc;

namespace CloudASPWebApp.Controllers
{
    public class HomeController : Controller
    {
        [CustomFilter]
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}

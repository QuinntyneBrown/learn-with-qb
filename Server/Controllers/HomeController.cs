using System.Web.Mvc;

namespace LearnWithQB.Server.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
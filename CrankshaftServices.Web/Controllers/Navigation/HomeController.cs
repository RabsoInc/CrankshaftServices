using Microsoft.AspNetCore.Mvc;

namespace CrankshaftServices.Web.Controllers.Navigation
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Navigation/Home/Index.cshtml");
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace Workshop.DevOps.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
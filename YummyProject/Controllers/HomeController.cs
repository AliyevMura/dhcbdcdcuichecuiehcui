using Microsoft.AspNetCore.Mvc;

namespace YummyProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

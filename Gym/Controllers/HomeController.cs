using Microsoft.AspNetCore.Mvc;

namespace Gym.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WhyUs()
        {
            return View();
        }
        public IActionResult Trainer()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace BusinesCardWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

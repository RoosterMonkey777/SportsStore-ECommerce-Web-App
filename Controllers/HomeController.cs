using Microsoft.AspNetCore.Mvc;

namespace SportsStore_ECommerce_Web_App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

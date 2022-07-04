using Microsoft.AspNetCore.Mvc;
using SportsStore_ECommerce_Web_App.Models;

namespace SportsStore_ECommerce_Web_App.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;

        // using dependency injection, and its approach allows the HomeController object to access the application’s repository
        // through the IStoreRepository interface without knowing which implementationclass has been configured.
        public HomeController(IStoreRepository repo)
        {
            repository=repo;
        }

        public IActionResult Index()
        {
            return View(repository.Products);
        }
    }
}

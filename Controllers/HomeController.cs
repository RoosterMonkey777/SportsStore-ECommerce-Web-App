using Microsoft.AspNetCore.Mvc;
using SportsStore_ECommerce_Web_App.Models;
using SportsStore_ECommerce_Web_App.Models.ViewModels;

namespace SportsStore_ECommerce_Web_App.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        // specify products per page
        public int PageSize = 3;

        // using dependency injection, and its approach allows the HomeController object to access the application’s repository
        // through the IStoreRepository interface without knowing which implementationclass has been configured.
        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index(int productPage = 1)=> 
            View(new ProductsListViewModel
  {
      Products = repository.Products.OrderBy(p => p.ProductID).Skip((productPage - 1) * PageSize).Take(PageSize),
      PagingInfo = new PagingInfo
      {
          CurrentPage = productPage,
          ItemsPerPage = PageSize,
          TotalItems = repository.Products.Count()
      }
  });

    }
}

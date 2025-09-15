using Microsoft.AspNetCore.Mvc;
using SQLitePCL;
using Entities.Models;
using Repositories;
using Repositories.Contracts;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        // Dependency Injection
        private readonly IRepositoryManager _manager;

        public ProductController(IRepositoryManager manager)
        {
            _manager = manager;
        }
        public IActionResult Index()
        {
            // Send to View Page
            var model = _manager.Product.GetAllProducts(false);
            return View(model);
        }

        public IActionResult Get(int id)
        {
            //Inversion of Control
            throw new NotImplementedException();
        }

    }
}
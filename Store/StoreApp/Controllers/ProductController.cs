using Microsoft.AspNetCore.Mvc;
using SQLitePCL;
using Entities.Models;
using Repositories;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        // Dependency Injection
        private readonly RepositoryContext _context;
        public ProductController(RepositoryContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Send to View Page
            var model = _context.Products.ToList();
            return View(model);
        }

        public IActionResult Get(int id)
        {
            //Inversion of Control
            Product pr = _context.Products.First(p=> p.ProductId.Equals(id));
            return View(pr);
        }

    }
}
using Microsoft.AspNetCore.Mvc;
using OnlineStore.AppServices.Product.Services;
using OnlineStore.DataAccess.Common;
using OnlineStore.Domain.Entities;

namespace OnlineStore.MVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(string name, string category)
        {
            ProductService productService = new ProductService();
            productService.AddAsync(name, category);

            return View();
        }
    }
}

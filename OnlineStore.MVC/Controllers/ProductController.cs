using Microsoft.AspNetCore.Mvc;
using OnlineStore.AppServices.Product.Services;
using OnlineStore.Contracts.ProductsDto;
using OnlineStore.DataAccess.Common;
using OnlineStore.Domain.Entities;

namespace OnlineStore.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

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
            var product = new ProductsDto
            {
                Name = name,
                Category = category
            };

            _productService.AddProductAsync(product);

            return View();
        }
    }
}

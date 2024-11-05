using Microsoft.AspNetCore.Mvc;
using OnlineStore.AppServices.Product.Services;
using OnlineStore.AppServices.ProductImage.Services;
using OnlineStore.Contracts.ProductsDto;
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

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductsDto productDto)
        {

            await _productService.AddAsync(productDto);

            var products = await _productService.GetAllAsync();
            return View("AllProduct", products);
        }

        [HttpGet]
        public IActionResult GetProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetProduct(ProductsDto productDto)
        {
            Products prod = await _productService.GetAsync(productDto);

            if (prod != null)
            {
                Console.WriteLine();
                Console.WriteLine($"Id = {prod.Id}, Name = {prod.Name}, Category = {prod.Category}, Image = {prod.Images}");

                foreach (var image in prod.Images)
                {
                    Console.WriteLine($"Image = {image}");
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Товар закончился или не существует");
            }

            return View(prod);
        }

        [HttpGet]
        public IActionResult GetAllProduct()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productService.GetAllAsync();
            return View("AllProduct", products);
        }

        [HttpPost]
        public async Task DeleteProduct(int id)
        {
            await _productService.DeleteAsync(id);
        }
    }
}

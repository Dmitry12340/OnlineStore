﻿using Microsoft.AspNetCore.Mvc;
using OnlineStore.AppServices.Product.Services;
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

            await _productService.AddProductAsync(productDto);

            return View();
        }

        [HttpGet]
        public IActionResult GetProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetProduct(ProductsDto productDto)
        {
            Products prod = await _productService.GetProductsAsync(productDto);

            if (prod != null)
            {
                Console.WriteLine();
                Console.WriteLine($"Id = {prod.Id}, Name = {prod.Name}, Category = {prod.Category}");

                Console.WriteLine();
            }
            else
                Console.WriteLine("Товар закончился или не существует");
            
            return View();
        }

        [HttpGet]
        public IActionResult GetAllProduct()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productService.GetAllProductsAsync();

            foreach (var product in products)
            {
                Console.WriteLine($"Id = {product.Id}, Name = {product.Name}, Category = {product.Category}");
            }
            return View("AllProduct", products);
        }
    }
}

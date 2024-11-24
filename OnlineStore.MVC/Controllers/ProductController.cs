using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.AppServices.Mediator.Product.Commands;
using OnlineStore.AppServices.Product.Services;
using OnlineStore.Contracts.ProductsDto;
using OnlineStore.Domain.Entities;

namespace OnlineStore.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMediator _mediator;

        public ProductController(IProductService productService,
            IMediator mediator)
        {
            _productService = productService;
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductsDto productDto)
        {
            var comand = new AddProductCommand(productDto);
            await _mediator.Send(comand);

            return RedirectToAction("Index", "Home");
            //await _productService.AddAsync(productDto);

            //var products = await _productService.GetAllAsync();
            //return View("AllProduct", products);
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

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _productService.DeleteAsync(id);
            return RedirectToAction("Index", "Home");
        }
    }
}

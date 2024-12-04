using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.AppServices.Product.Services;
using OnlineStore.AppServices.UserRoles.Services;
using OnlineStore.Domain.Entities;
using OnlineStore.MVC.Models;
using System.Diagnostics;

namespace OnlineStore.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly IUserRolesService _userRolesService;

        public HomeController(ILogger<HomeController> logger, 
            IProductService productService,
            IUserRolesService userRolesService)
        {
            _logger = logger;
            _productService = productService;
            _userRolesService = userRolesService;
        }

        CancellationToken cancellation;

        public async Task<IActionResult> Index(CancellationToken cancellation)
        {
            //try
            //{
            //    await _userRolesService.GetUserRoles(2, cancellation);
            //}
            //catch(ArgumentNullException ex)
            //{
            //    Console.WriteLine("Пользователь не найден");
            //    Console.WriteLine(ex.Message);
            //}

            var products = await _productService.GetAllAsync();
            return View("AllProduct", products);
        }

        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

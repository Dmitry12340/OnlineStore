using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.AppServices.Authentication.Services;
using OnlineStore.AppServices.Product.Services;
using OnlineStore.AppServices.Roles.Services;
using OnlineStore.Domain.Entities;
using OnlineStore.MVC.Models;
using System.Diagnostics;

namespace OnlineStore.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly IAuthenticationService _authenticationService;
        private readonly IRolesService _rolesService;

        public HomeController(ILogger<HomeController> logger, 
            IProductService productService,
            IAuthenticationService authenticationService,
            IRolesService rolesService)
        {
            _logger = logger;
            _productService = productService;
            _authenticationService = authenticationService;
            _rolesService = rolesService;
        }

        CancellationToken cancellation;

        public async Task<IActionResult> Index()
        {
            var user1 = new ApplicationUser();

            //await _rolesService.AddAsync("Admin", CancellationToken.None);
            await _authenticationService.AddRoleToUserAsync("diman_chelyad@mail.ru", "Admin", cancellation);

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

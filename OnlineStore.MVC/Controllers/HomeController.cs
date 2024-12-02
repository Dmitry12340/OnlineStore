using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.AppServices.Authentication.Services;
using OnlineStore.AppServices.Product.Services;
using OnlineStore.AppServices.Roles.Services;
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
        private readonly IRolesService _rolesService;
        private readonly IUserRolesService _userRolesService;
        private readonly IAuthenticationService _authenticationService;

        public HomeController(ILogger<HomeController> logger, 
            IProductService productService,
            IRolesService rolesService,
            IUserRolesService userRolesService,
            IAuthenticationService authenticationService)
        {
            _logger = logger;
            _productService = productService;
            _rolesService = rolesService;
            _userRolesService = userRolesService;
            _authenticationService = authenticationService;
        }

        CancellationToken cancellation;

        public async Task<IActionResult> Index()
        {
            var user1 = new ApplicationUser();

            //await _rolesService.AddAsync("User", CancellationToken.None);
            //await _userRolesService.AddRoleToUserAsync("Dmitry@mail.ru", "Admin", cancellation);
            //await _userRolesService.RemoveRoleFromUser("Dmitry@mail.ru", "Admin", cancellation);

            _authenticationService.GetAllAsync(cancellation);

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

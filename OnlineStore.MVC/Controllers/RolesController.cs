using Microsoft.AspNetCore.Mvc;
using OnlineStore.AppServices.Product.Services;
using OnlineStore.AppServices.Roles.Services;
using OnlineStore.Domain.Entities;

namespace OnlineStore.MVC.Controllers
{
    public class RolesController : Controller
    {
        private readonly IRolesService _rolesService;
        private readonly IProductService _productService;

        public RolesController(IRolesService rolesService,
            IProductService productService)
        {
            _rolesService = rolesService;
            _productService = productService;
        }
        public async Task<IActionResult> Index()
        {
            var roles = _rolesService.GetAll();
            foreach (var role in roles)
            {
                Console.WriteLine(role);
            }

            return View(roles);
        }
    }
}

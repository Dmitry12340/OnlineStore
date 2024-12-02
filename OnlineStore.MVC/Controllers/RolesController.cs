using Microsoft.AspNetCore.Mvc;
using OnlineStore.AppServices.Roles.Services;
using OnlineStore.Contracts.Users;

namespace OnlineStore.MVC.Controllers
{
    public class RolesController : Controller
    {
        private readonly IRolesService _rolesService;

        public RolesController(IRolesService rolesService)
        {
            _rolesService = rolesService;
        }
        public async Task<IActionResult> Index()
        {
            return RedirectToAction("GetAllRoles");
        }


        [HttpGet]
        public IActionResult AddRoles()
        {
            return View("AddRoles");
        }


        [HttpPost]
        public async Task<IActionResult> AddRoles(RoleDto roleDto, CancellationToken cancellation)
        {
            await _rolesService.AddAsync(roleDto.Name, cancellation);
            return RedirectToAction("GetAllRoles");
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRoles()
        {
            var roles = _rolesService.GetAll();
            foreach (var role in roles)
            {
                Console.WriteLine(role);
            }

            return View(roles);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteRoles([FromHeader]RoleDto roleDto, CancellationToken cancellation)
        {
            await _rolesService.DeleteAsync(roleDto.Id, cancellation);
            return RedirectToAction("GetAllRoles");
        }
    }
}

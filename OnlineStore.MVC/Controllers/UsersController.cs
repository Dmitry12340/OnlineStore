using Microsoft.AspNetCore.Mvc;
using OnlineStore.AppServices.UserRoles.Services;

namespace OnlineStore.MVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserRolesService _userRolesService;
        public UsersController(IUserRolesService userRolesService)
        {
            _userRolesService = userRolesService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

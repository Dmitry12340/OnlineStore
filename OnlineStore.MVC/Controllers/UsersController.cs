using Microsoft.AspNetCore.Mvc;
using OnlineStore.AppServices.UserRoles.Services;
using OnlineStore.AppServices.Authentication.Services;
using OnlineStore.Contracts.Users;

namespace OnlineStore.MVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserRolesService _userRolesService;
        private readonly IAuthenticationService _authenticationService;
        public UsersController(IUserRolesService userRolesService,
            IAuthenticationService authenticationService)
        {
            _userRolesService = userRolesService;
            _authenticationService = authenticationService;
        }
        public IActionResult Index(CancellationToken cancellation)
        {
            var listUsers = _authenticationService.GetAll(cancellation);
            var listUserDto = new List<UserDto>();
            foreach (var user in listUsers)
            {
                listUserDto.Add(new UserDto { UserName = user.UserName, Id = user.Id });
            }
            return View(listUserDto);
        }
    }
}

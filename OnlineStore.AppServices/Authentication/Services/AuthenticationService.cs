using Microsoft.AspNetCore.Identity;
using OnlineStore.Domain.Entities;

namespace OnlineStore.AppServices.Authentication.Services
{
    /// <summary>
    /// Сервис аутентификации пользователя.
    /// </summary>
    public sealed class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AuthenticationService(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public Task RegisterAsync(string email, string password, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task SignInAsync(string email, string password, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                throw new UnauthorizedAccessException("Такого пользователя не существует");
            }
        }

        public Task SignOutAsync(CancellationToken cancellationToken)
        {
            return _signInManager.SignOutAsync();
        }
    }
}

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

        /// <inheritdoc>
        public async Task<bool> RegisterAsync(string email, string password, CancellationToken cancellationToken)
        {
            var user = new ApplicationUser
            {
                UserName = email,
                Email = email,
            };

            var registeredUser = await _userManager.CreateAsync(user, password);

            return registeredUser != null;
        }

        /// <inheritdoc>
        public async Task<bool> SignInAsync(string email, string password, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                throw new UnauthorizedAccessException("Неправельный email или пароль.");
            }

            var isPasswordMatched = await _userManager.CheckPasswordAsync(user, password);
            if (isPasswordMatched)
            {
                await _signInManager.SignInAsync(user, isPersistent: true);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <inheritdoc>
        public Task SignOutAsync(CancellationToken cancellationToken)
        {
            return _signInManager.SignOutAsync();
        }
    }
}

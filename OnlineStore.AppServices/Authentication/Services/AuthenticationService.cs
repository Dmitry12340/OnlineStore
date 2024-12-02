using Microsoft.AspNetCore.Identity;
using OnlineStore.Contracts.Users;
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
        private readonly RoleManager<ApplicationRole> _roleManager;


        public AuthenticationService(SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager, 
            RoleManager<ApplicationRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        /// <inheritdoc>
        public async Task<bool> RegisterAsync(string email, string password, CancellationToken cancellationToken)
        {
            //Создаем пользователя
            var user = new ApplicationUser
            {
                UserName = email,
                Email = email,
            };

            //Добавляем пользователя в базу данных
            var registeredUser = await _userManager.CreateAsync(user, password);


            //Проверяем наличие роли User
            if(await _roleManager.RoleExistsAsync("User"))
            {
                //Наделяем правами User нового пользователя
                await _userManager.AddToRoleAsync(user, "User");
            }

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

        public List<ApplicationUser> GetAll(CancellationToken cancellationToken)
        {
            var users = _userManager.Users.ToList();
            foreach (var user in users)
            {
                Console.WriteLine($"Id = {user.Id}, Name = {user.UserName}");
            }
            return users;
        }
    }
}

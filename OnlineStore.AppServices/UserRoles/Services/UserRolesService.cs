using Microsoft.AspNetCore.Identity;
using OnlineStore.Domain.Entities;

namespace OnlineStore.AppServices.UserRoles.Services
{
    /// <summary>
    /// Сервис для работы с ролями пользователей.
    /// </summary>
    public sealed class UserRolesService : IUserRolesService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public UserRolesService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        /// <inheritdoc>
        public async Task AddRoleToUserAsync(string email, string roleName, CancellationToken cancellationToken)
        {
            ApplicationUser user = await _userManager.FindByEmailAsync(email);
            await _userManager.AddToRoleAsync(user, roleName);
        }
    }
}

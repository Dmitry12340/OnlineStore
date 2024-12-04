using Microsoft.AspNetCore.Identity;
using OnlineStore.Contracts.Users;
using OnlineStore.Domain.Entities;
using System.Data.Entity;

namespace OnlineStore.AppServices.UserRoles.Services
{
    /// <summary>
    /// Сервис для работы с ролями пользователей.
    /// </summary>
    public sealed class UserRolesService : IUserRolesService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        public UserRolesService(UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        /// <inheritdoc>
        public async Task AddRoleToUserAsync(string email, string roleName, CancellationToken cancellationToken)
        {
            ApplicationUser user = await _userManager.FindByEmailAsync(email);
            await _userManager.AddToRoleAsync(user, roleName);
        }

        /// <inheritdoc>
        public async Task RemoveRoleFromUser(string email, string roleName, CancellationToken cancellationToken)
        {
            ApplicationUser user = await _userManager.FindByEmailAsync(email);
            await _userManager.RemoveFromRoleAsync(user, roleName);
        }

        /// <inheritdoc>
        public async Task<IList<string>> GetUserRoles(int id, CancellationToken cancellation)
        {
            var user = _userManager.Users.SingleOrDefault(u =>  u.Id == id);
            

            if(user == null)
            {
                throw new ArgumentNullException(nameof(user), $"Пользователь не найден id = {id}");
            }

            var userRoles = await _userManager.GetRolesAsync(user);
            foreach (var role in userRoles)
            {
                Console.WriteLine(role);
            }
            return userRoles;
        }

        ////public Task<UserRoleDto> GetUser(int id, CancellationToken cancellation)
        ////{
        ////    UserDto userDto = new UserDto();
        ////    RoleDto roleDto = new RoleDto();
        ////    UserRoleDto userRoleDto = new UserRoleDto { RoleDto = roleDto, UserDto = userDto };
        ////    return 
        ////}
    }
}

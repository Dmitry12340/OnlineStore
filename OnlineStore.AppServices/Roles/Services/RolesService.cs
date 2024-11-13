using Microsoft.AspNetCore.Identity;
using OnlineStore.Domain.Entities;

namespace OnlineStore.AppServices.Roles.Services
{
    /// <summary>
    /// Сервис для работы с ролями.
    /// </summary>
    public sealed class RolesService : IRolesService
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        public RolesService(RoleManager<ApplicationRole> roleManager)
        {
            _roleManager = roleManager;
        }

        /// <inheritdoc>
        public async Task AddAsync(string roleName, CancellationToken cancellation)
        {
            var role = new ApplicationRole { Name = roleName };
            await _roleManager.CreateAsync(role);
        }

        /// <inheritdoc>
        public async Task DeleteAsync(int id, CancellationToken cancellation)
        {
            var role = new ApplicationRole { Id = id };
            await _roleManager.DeleteAsync(role);
        }
    }
}

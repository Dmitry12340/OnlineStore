﻿using Microsoft.AspNetCore.Identity;
using OnlineStore.Contracts.Users;
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
            var role = await _roleManager.FindByIdAsync(id.ToString());

            if(role != null)
            {
                await _roleManager.DeleteAsync(role);
            }
            else
            {
                throw new KeyNotFoundException($"Role with ID {id} not found.");
            }
        }

        /// <inheritdoc>
        public List<RoleDto> GetAll()
        {
            return _roleManager.Roles
        .Select(role => new RoleDto { Name = role.Name, Id = role.Id })
        .ToList();
        }
    }
}

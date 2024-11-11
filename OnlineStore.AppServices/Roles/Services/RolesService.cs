﻿using Microsoft.AspNetCore.Identity;
using OnlineStore.Domain.Entities;

namespace OnlineStore.AppServices.Roles.Services
{
    public sealed class RolesService : IRolesService
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        public RolesService(RoleManager<ApplicationRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task AddAsync(string roleName, CancellationToken cancellation)
        {
            var role = new ApplicationRole { Name = roleName };
            await _roleManager.CreateAsync(role);
        }
    }
}

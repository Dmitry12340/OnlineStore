using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.AppServices.UserRoles.Services
{
    public interface IUserRolesService
    {
        Task AddAsync(int userId, int  roleId);
    }
}

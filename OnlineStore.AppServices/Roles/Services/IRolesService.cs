using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.AppServices.Roles.Services
{
    public interface IRolesService
    {
        Task AddAsync(string roleName, CancellationToken cancellation);
    }
}

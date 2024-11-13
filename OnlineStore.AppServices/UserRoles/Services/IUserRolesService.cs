using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.AppServices.UserRoles.Services
{
    /// <summary>
    /// Интерфейс сервиса для работы с ролями пользователей.
    /// </summary>
    public interface IUserRolesService
    {
        /// <summary>
        /// Добавить роль пользователю.
        /// </summary>
        /// <param name="email">Email пользователя.</param>
        /// <param name="roleName">Имя роли.</param>
        /// <param name="cancellationToken">Токен отмены.</param>
        Task AddRoleToUserAsync(string email, string roleName, CancellationToken cancellationToken);

        /// <summary>
        /// Удалить роль пользователя.
        /// </summary>
        /// <param name="email">Email пользователя.</param>
        /// <param name="roleName">Имя роли.</param>
        /// <param name="cancellationToken">Токен отмены.</param>
        Task RemoveRoleFromUser(string email, string roleName, CancellationToken cancellationToken);
    }
}

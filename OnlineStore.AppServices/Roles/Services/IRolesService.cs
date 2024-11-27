using OnlineStore.Contracts.Users;

namespace OnlineStore.AppServices.Roles.Services
{
    /// <summary>
    /// Интерфейс сервиса для работы с ролями.
    /// </summary>
    public interface IRolesService
    {
        /// <summary>
        /// Добавить роль.
        /// </summary>
        /// <param name="roleName">Имя роли.</param>
        /// <param name="cancellation">Токен отмены.</param>
        Task AddAsync(string roleName, CancellationToken cancellation);

        /// <summary>
        /// Удалить роль.
        /// </summary>
        /// <param name="id">Идентификатор роли.</param>
        /// <param name="cancellation">Токен отмены.</param>
        Task DeleteAsync(int id, CancellationToken cancellation);

        /// <summary>
        /// Получить все существующие роли.
        /// </summary>
        /// <returns>Список ролей(транспортная модель).</returns>
        public List<RoleDto> GetAll();
    }
}

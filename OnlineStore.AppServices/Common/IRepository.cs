namespace OnlineStore.AppServices.Common
{
    /// <summary>
    /// Интерфейс общего репозитория.
    /// </summary>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Получает сущность по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        Task<T> GetAsync(int id);

        /// <summary>
        /// Добавляет сущность в БД.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        Task AddAsync(T entity);

        /// <summary>
        /// Получает все записи.
        /// </summary>
        Task<List<T>> GetAllAsync();

        /// <summary>
        /// Обновляет существующую сущность в БД.
        /// </summary>
        /// <param name="entity">Сущность с обновлёнными данными.</param>
        Task UpdateAsync(T entity);
    }
}
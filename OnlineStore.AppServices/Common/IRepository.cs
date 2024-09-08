using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// Добавляет переданную сущность.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        Task AddAsync(T entity);
    }
}
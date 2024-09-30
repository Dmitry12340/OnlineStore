using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.AppServices.Product.Services
{
    /// <summary>
    /// Интерфейс сервиса продукта.
    /// </summary>
    public interface IProductService
    {
        /// <summary>
        /// Метод добавляет продукт.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="category">Категория.</param>
        Task AddAsync(string name, string category);

        /// <summary>
        /// Метод удаляет продукт.
        /// </summary>
        /// <param name="name">Имя.</param>
        //Task DeleteAsync(string name);
    }
}

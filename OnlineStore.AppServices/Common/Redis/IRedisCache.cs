using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.AppServices.Common.Redis
{
    /// <summary>
    /// Интерфейс по работе с RedisCache.
    /// </summary>
    public interface IRedisCache
    {
        /// <summary>
        /// Получает данные из Redis по ключу.
        /// </summary>
        /// <param name="key">Ключ.</param>
        Task<string> GetAsync(string key);

        /// <summary>
        /// Записывает данные в Redis по ключу.
        /// </summary>
        /// <param name="key">Ключ.</param>
        /// <param name="value">Значение.</param>
        Task SetStringAsync(string key, string value);
    }
}

using StackExchange.Redis;

namespace OnlineStore.AppServices.Common.Redis
{
    /// <summary>
    /// Сервис по работе с RedisCache.
    /// </summary>
    public class RedisCache : IRedisCache
    {
        private readonly IDatabase _redisDb;

        public RedisCache(IDatabase redisDb)
        {
            _redisDb = redisDb;
        }

        /// <inheritdoc>
        public async Task<string> GetAsync(string key)
        {
            return await _redisDb.StringGetAsync(key);
        }

        /// <inheritdoc>
        public async Task SetStringAsync(string key, string value)
        {
            await _redisDb.StringSetAsync(key, value);
        }
    }
}

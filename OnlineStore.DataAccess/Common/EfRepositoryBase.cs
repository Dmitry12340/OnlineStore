using Microsoft.EntityFrameworkCore;
using OnlineStore.AppServices.Common;

namespace OnlineStore.DataAccess.Common
{
    /// <summary>
    /// Базовый репозиторий для работы с БД через EF.
    /// </summary>
    public class EfRepositoryBase<T> : IRepository<T> where T : class
    {
        public readonly OnlineStoreDbContext _dbContext;

        /// <inheritdoc/>
        public EfRepositoryBase(OnlineStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <inheritdoc/>
        public async Task AddAsync(T entity)
        {
            _dbContext.AddAsync(entity).AsTask();
            await _dbContext.SaveChangesAsync();
        }

        /// <inheritdoc/>
        public virtual Task<List<T>> GetAllAsync()
        {
            return _dbContext.Set<T>().ToListAsync();
        }

        /// <inheritdoc/>
        public virtual Task<T> GetAsync(int id)
        {
            return _dbContext.FindAsync<T>(id).AsTask();
        }
    }
}

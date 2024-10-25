using System.Data.Entity;
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
            await _dbContext.AddAsync(entity).AsTask();
            await _dbContext.SaveChangesAsync();
        }

        /// <inheritdoc/>
        public async virtual Task<T> GetAsync(int id)
        {
            return await _dbContext.FindAsync<T>(id).AsTask();
        }

        /// <inheritdoc/>
        public async virtual Task<List<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}

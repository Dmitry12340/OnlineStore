using OnlineStore.AppServices.Common;

namespace OnlineStore.DataAccess.Common
{
    public class EfRepositoryBase<T> : IRepository<T> where T : class
    {
        public readonly OnlineStoreDbContex DbContext;

        public EfRepositoryBase(OnlineStoreDbContex dbContext)
        {
            DbContext = dbContext;
        }

        public async Task AddAsync(T entity)
        {
            DbContext.AddAsync(entity);
        }

        //public Task<List<T>> GetAllAsync()
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<T> GetAsync(int id)
        {
            return await DbContext.FindAsync<T>(id);
        }
    }
}

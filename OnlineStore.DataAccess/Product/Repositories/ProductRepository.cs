using OnlineStore.DataAccess.Common;
using OnlineStore.Domain.Entities;

namespace OnlineStore.DataAccess.Product.Repositories
{
    public sealed class ProductRepository : EfRepositoryBase<Products>, IProductRepository
    {
        public ProductRepository(OnlineStoreDbContext dbContext) : base(dbContext)
        {
        }

        public async Task AddAsync(Products entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            //_dbContext.Products.Add(entity);
            //await _dbContext.SaveChangesAsync();

            //_dbContext.Set<Products>().Add(entity);
            //_dbContext
        }

        public async Task<Products> GetAsync(string name)
        {
            return _dbContext.Set<Products>().FirstOrDefault(x => x.Name == name);
            //return _dbContext.Products.FirstOrDefault(x => x.Name == name);
        }
    }
}

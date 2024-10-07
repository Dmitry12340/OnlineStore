using OnlineStore.DataAccess.Common;
using OnlineStore.Domain.Entities;
using System.Data.Entity;

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
            return _dbContext.Products.FirstOrDefault(x => x.Name == name);

            //В таком виде не работает
            //return await _dbContext.Products.FirstOrDefaultAsync(x => x.Name == name);
        }

        public async Task<List<Products>> GetAllProductAsync()
        {
            return _dbContext.Products.ToList();

            //В таком виде не работает
            //return await _dbContext.Products.ToListAsync();
        }
    }
}

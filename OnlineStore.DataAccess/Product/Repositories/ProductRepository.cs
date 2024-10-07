using OnlineStore.DataAccess.Common;
using OnlineStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

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
            return await _dbContext.Products.FirstOrDefaultAsync(x => x.Name == name && !x.IsDeleted);
        }

        public async Task<List<Products>> GetAllProductAsync()
        {
            //return await _dbContext.Products.ToListAsync();

            var products = await _dbContext.Products.ToListAsync();

            List<Products> notIsDeleted = new List<Products>();
            foreach (var product in products)
            {
                if (!product.IsDeleted)
                {
                    notIsDeleted.Add(product);
                }
            }
            return notIsDeleted;
        }
    }
}

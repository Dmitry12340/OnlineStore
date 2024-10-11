using OnlineStore.DataAccess.Common;
using OnlineStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using OnlineStore.AppServices.Product.Repositories;

namespace OnlineStore.DataAccess.Product.Repositories
{
    public sealed class ProductRepository : EfRepositoryBase<Products>, IProductRepository
    {
        public ProductRepository(OnlineStoreDbContext dbContext) : base(dbContext)
        {
        }

        public async Task AddAsync(Products entity)
        {
            await _dbContext.Products.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Products> GetAsync(string name)
        {
            return await _dbContext.Products.Include(p => p.Images).FirstOrDefaultAsync(x => x.Name == name && !x.IsDeleted);
        }

        public async Task<List<Products>> GetAllAsync()
        {
            return await _dbContext.Products.Include(p => p.Images).Where(p => !p.IsDeleted).ToListAsync();
        }
    }
}

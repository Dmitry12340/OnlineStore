using OnlineStore.AppServices.ProductImage.Repositories;
using OnlineStore.DataAccess.Common;
using OnlineStore.Domain.Entities;
using System.Data.Entity;

namespace OnlineStore.DataAccess.ProductImage.Repositories
{
    public sealed class ProductImagesRepository : EfRepositoryBase<ProductImages>, IProductImagesRepository
    {
        public ProductImagesRepository(OnlineStoreDbContext dbContext) : base(dbContext)
        {
        }

        public async Task AddImagesAsync(ProductImages entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<ProductImages>> GetImagesAsync(int productId)
        {
            return await _dbContext.ProductImages.Where(e => e.ProductId == productId).ToListAsync();
        }

        public async Task<List<ProductImages>> GetAllImagesAsync()
        {
            return await _dbContext.ProductImages.ToListAsync();
        }
    }
}

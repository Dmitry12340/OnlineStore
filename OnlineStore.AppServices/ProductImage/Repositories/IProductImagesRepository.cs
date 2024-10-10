using OnlineStore.AppServices.Common;
using OnlineStore.Domain.Entities;

namespace OnlineStore.AppServices.ProductImage.Repositories
{
    public interface IProductImagesRepository : IRepository<ProductImages>
    {
        Task AddImagesAsync(ProductImages entity);

        Task<List<ProductImages>> GetImagesAsync(int productId);

        Task<List<ProductImages>> GetAllImagesAsync();
    }
}

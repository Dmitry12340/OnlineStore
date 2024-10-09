using OnlineStore.Contracts.ProductsDto;
using OnlineStore.Domain.Entities;

namespace OnlineStore.AppServices.ProductImage.Services
{
    /// <summary>
    /// Интерфейс сервиса работы с изображением продукта
    /// </summary>
    public interface IProductImagesService
    {
        Task AddProductImagesAsync(ProductsDto productsDto);
        Task<List<ProductImages>> GetProductImagesAsync(int productId);
        Task<List<ProductImages>> GetAllProductImagesAsync();
    }
}

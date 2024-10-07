using OnlineStore.Contracts.ProductsDto;
using OnlineStore.Domain.Entities;

namespace OnlineStore.AppServices.Product.Services
{
    /// <summary>
    /// Интерфейс сервиса продукта.
    /// </summary>
    public interface IProductService
    {
        Task AddProductAsync(ProductsDto productsDto);

        Task<Products> GetProductsAsync(ProductsDto productsDto);

        Task<List<Products>> GetAllProductsAsync();
    }
}

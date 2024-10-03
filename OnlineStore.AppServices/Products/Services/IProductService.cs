using OnlineStore.Contracts.ProductsDto;

namespace OnlineStore.AppServices.Product.Services
{
    /// <summary>
    /// Интерфейс сервиса продукта.
    /// </summary>
    public interface IProductService
    {
        Task AddProductAsync(ProductsDto productsDto);
    }
}

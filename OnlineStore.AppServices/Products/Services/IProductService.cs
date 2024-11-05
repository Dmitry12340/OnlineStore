using OnlineStore.Contracts.ProductsDto;
using OnlineStore.Domain.Entities;

namespace OnlineStore.AppServices.Product.Services
{
    /// <summary>
    /// Интерфейс сервиса продукта.
    /// </summary>
    public interface IProductService
    {
        Task AddAsync(ProductsDto productsDto);

        Task<Products> GetAsync(ProductsDto productsDto);

        Task<List<Products>> GetAllAsync();

        Task DeleteAsync(int id);
    }
}

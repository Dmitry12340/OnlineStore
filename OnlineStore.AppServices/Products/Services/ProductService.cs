using OnlineStore.AppServices.Product.Repositories;
using OnlineStore.Contracts.ProductsDto;
using OnlineStore.Domain.Entities;

namespace OnlineStore.AppServices.Product.Services
{
    public sealed class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task AddAsync(ProductsDto productsDto)
        {

            var product = new Products
            {
                Name = productsDto.Name,
                Category = productsDto.Category,
                Description = productsDto.Description
            };

            await _repository.AddAsync(product);
        }

        public Task<Products> GetAsync(ProductsDto productsDto)
        {
            return _repository.GetAsync(productsDto.Name);
        }

        public async Task<List<Products>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }
    }
}

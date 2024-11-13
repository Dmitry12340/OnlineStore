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

            List<ProductImages> productImages = new List<ProductImages>();
            foreach (var image in productsDto.Images)
            {
                productImages.Add(new ProductImages { Path = image });
            }

            var product = new Products
            {
                Name = productsDto.Name,
                Category = productsDto.Category,
                Description = productsDto.Description,
                Price = productsDto.Price,
                Quantity = productsDto.Quantity,
                Images = productImages
            };

            await _repository.AddAsync(product);
        }

        public async Task<Products> GetAsync(ProductsDto productsDto)
        {
            var osgv = await _repository.GetAsync(productsDto.Id);
            return osgv;
        }

        public async Task<List<Products>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}

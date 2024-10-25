using OnlineStore.AppServices.ProductImage.Repositories;
using OnlineStore.Contracts.ProductsDto;
using OnlineStore.Domain.Entities;

namespace OnlineStore.AppServices.ProductImage.Services
{
    /// <summary>
    /// Сервис для работы с изображением продукта
    /// </summary>
    public sealed class ProductImagesService : IProductImagesService
    {
        private readonly IProductImagesRepository _repository;

        public ProductImagesService(IProductImagesRepository repository)
        {
            _repository = repository;
        }

        public async Task AddProductImagesAsync(ProductsDto productsDto)
        {
            foreach(var image in productsDto.Images)
            {
                ///await _repository.AddImagesAsync(image);
            }
        }

        public async Task<List<ProductImages>> GetProductImagesAsync(int productId)
        {
            return await _repository.GetImagesAsync(productId);
        }

        public async Task<List<ProductImages>> GetAllProductImagesAsync()
        {
            return await _repository.GetAllImagesAsync();
        }
    }
}

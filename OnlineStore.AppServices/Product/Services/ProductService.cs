using OnlineStore.Domain.Entities;

namespace OnlineStore.AppServices.Product.Services
{
    public sealed class ProductService : IProductService
    {
        public async Task AddAsync(string name, string category)
        {
            var product = new Domain.Entities.Product
            {
                Name = name,
                Category = category,
                IsDeleted = false
            };
        }

        public Task DeleteAsync(string name)
        {
            
        }
    }
}

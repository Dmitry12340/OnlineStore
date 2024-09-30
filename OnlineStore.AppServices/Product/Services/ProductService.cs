

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

            using (OnlineStoreDbContext db = new OnlineStoreDbContext())
            {
                db.Products.Add(product);
                db.SaveChanges();
            }
        }

        public Task DeleteAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}

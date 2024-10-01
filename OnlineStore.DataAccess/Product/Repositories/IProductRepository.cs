using OnlineStore.Domain.Entities;

namespace OnlineStore.DataAccess.Product.Repositories
{
    public interface IProductRepository
    {
        Task AddAsync(Domain.Entities.Product entity);
    }
}

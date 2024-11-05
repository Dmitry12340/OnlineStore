using OnlineStore.AppServices.Common;
using OnlineStore.Domain.Entities;

namespace OnlineStore.AppServices.Product.Repositories
{
    public interface IProductRepository : IRepository<Products>
    {
        Task AddAsync(Products entity);

        Task<Products> GetAsync(int id);

        Task<List<Products>> GetAllAsync();

        Task UpdateAsync(Products entity);

        Task DeleteAsync(int id);
    }
}

using OnlineStore.AppServices.Common;
using OnlineStore.Domain.Entities;

namespace OnlineStore.AppServices.Product.Repositories
{
    public interface IProductRepository : IRepository<Products>
    {
        Task AddAsync(Products entity);

        Task<Products> GetAsync(string name);

        Task<List<Products>> GetAllAsync();
    }
}

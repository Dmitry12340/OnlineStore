using OnlineStore.AppServices.Common;
using OnlineStore.Domain.Entities;

namespace OnlineStore.DataAccess.Product.Repositories
{
    public interface IProductRepository : IRepository<Products>
    {
        Task AddAsync(Products entity);
    }
}

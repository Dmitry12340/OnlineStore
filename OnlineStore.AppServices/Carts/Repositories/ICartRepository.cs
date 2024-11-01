using OnlineStore.AppServices.Common;

namespace OnlineStore.AppServices.Cart.Repositories
{
    public interface ICartRepository : IRepository<Domain.Entities.Cart>
    {
        Task<Domain.Entities.Cart> GetCartByUserAsync(int userId);
    }
}

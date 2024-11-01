using OnlineStore.AppServices.Cart.Repositories;
using OnlineStore.Contracts.Enums;
using OnlineStore.DataAccess.Common;
using OnlineStore.Domain.Entities;
using System.Data.Entity;

namespace OnlineStore.DataAccess.Carts.Repositories
{
    public sealed class CartRepository : EfRepositoryBase<Cart>, ICartRepository
    {
        public CartRepository(OnlineStoreDbContext dbContext) : base(dbContext)
        {
        }
        public Task<Cart> GetCartByUserAsync(int userId)
        {
            return _dbContext.Set<Cart>()
                .Where(c => c.UserId == userId)
                .Where(c => c.StatusId == (int)CartStatusEnum.New)
                .Include(c => c.Products)
                .FirstOrDefaultAsync();
        }
    }
}

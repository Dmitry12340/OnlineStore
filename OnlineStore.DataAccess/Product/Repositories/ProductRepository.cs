using OnlineStore.DataAccess.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataAccess.Product.Repositories
{
    public sealed class ProductRepository : OnlineStoreDbContext<Domain.Entities.Product>, IProductRepository
    {
        public Task AddAsync(Domain.Entities.Product entity)
        {
            throw new NotImplementedException();
        }
    }
}

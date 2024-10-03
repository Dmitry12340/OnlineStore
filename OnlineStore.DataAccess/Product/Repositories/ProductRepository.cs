﻿using OnlineStore.DataAccess.Common;
using OnlineStore.Domain.Entities;

namespace OnlineStore.DataAccess.Product.Repositories
{
    public sealed class ProductRepository : EfRepositoryBase<Products>, IProductRepository
    {
        public ProductRepository(OnlineStoreDbContext dbContext) : base(dbContext)
        {
        }

        public async Task AddAsync(Products entity)
        {
            await _dbContext.AddAsync(entity);
        }
    }
}

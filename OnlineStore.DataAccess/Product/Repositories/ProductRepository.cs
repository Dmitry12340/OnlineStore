﻿using OnlineStore.DataAccess.Common;
using OnlineStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using OnlineStore.AppServices.Product.Repositories;

namespace OnlineStore.DataAccess.Product.Repositories
{
    public sealed class ProductRepository : EfRepositoryBase<Products>, IProductRepository
    {
        public ProductRepository(OnlineStoreDbContext dbContext) : base(dbContext)
        {
        }

        public async Task AddAsync(Products entity)
        {
            await _dbContext.Products.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Products> GetAsync(int id)
        {
            return await _dbContext.Products.Include(p => p.Images).FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        }

        public async Task<List<Products>> GetAllAsync()
        {
            return await _dbContext.Products.Include(p => p.Images).Where(p => !p.IsDeleted).ToListAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var product = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
            if (product != null)
            {
                product.IsDeleted = true;
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException($"Продук с ID {id} не найден или уже удален.");
            }
        }
    }
}

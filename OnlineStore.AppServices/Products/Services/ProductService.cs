﻿using OnlineStore.Contracts.ProductsDto;
using OnlineStore.DataAccess.Product.Repositories;
using OnlineStore.Domain.Entities;

namespace OnlineStore.AppServices.Product.Services
{
    public sealed class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task AddProductAsync(ProductsDto productsDto)
        {
            var product = new Products
            {
                Name = productsDto.Name,
                Category = productsDto.Category
            };

            await _repository.AddAsync(product);
        }

        public Task<Products> GetProductsAsync(ProductsDto productsDto)
        {
            return _repository.GetAsync(productsDto.Name);
        }

        public async Task<List<Products>> GetAllProductsAsync()
        {
            return await _repository.GetAllProductAsync();
        }
    }
}

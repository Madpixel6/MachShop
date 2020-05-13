﻿using System.Collections.Generic;
using System.Linq;
using MachShop.Products.Domain.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MachShop.Products.Infrastructure.Repositories
{
    internal class ProductsRepository : IProductsRepository
    {
        private readonly ProductsContext _productsContext;
        public ProductsRepository(ProductsContext productsContext)
            => _productsContext = productsContext;
        public async Task AddAsync(Product entity)
            => await _productsContext.Products.AddAsync(entity);

        public async Task<IEnumerable<Product>> GetAllAsync()
            => await _productsContext.Products.ToListAsync();

        public void Remove(Product entity)
            => _productsContext.Products.Remove(entity);
    }
}
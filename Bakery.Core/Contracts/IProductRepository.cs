﻿using Bakery.Core.DTOs;
using Bakery.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bakery.Core.Contracts
{
    public interface IProductRepository
    {
        Task<int> GetCountAsync();
        Task AddRangeAsync(IEnumerable<Product> products);

        Task<Product[]> GetAllAsync();

        Task AddAsync(Product product);

        void Update(Product product);

        Task<Product> GetByIdAsync(int id);
    }
}
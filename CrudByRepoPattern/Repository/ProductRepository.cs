﻿using CrudByRepoPattern.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;

namespace CrudByRepoPattern.Repository
{
   
    public class ProductRepository : IProductRepository
    {

        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context) 
        {

            _context = context;
                
        }

        public async Task AddProduct(Product product)
        {

             _context.Products.Add(product);
               await _context.SaveChangesAsync();
            
        }

        public async Task DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
               _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
            
        }

        

        public async Task<IEnumerable<Product>> GetAllProduct()
        {
           return await _context.Products.ToListAsync();
            
        }

        
        public async Task<Product> GetProductById(int id)
        {
            return await _context.Products.FindAsync(id);
           
        }

        public async Task UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}

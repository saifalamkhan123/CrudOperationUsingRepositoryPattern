using CrudByRepoPattern.Models;

namespace CrudByRepoPattern.Repository
{
    public interface IProductRepository
    {
        public Task<IEnumerable<Product>> GetAllProduct();
        public Task<Product> GetProductById(int id);
        public Task AddProduct(Product product);
        public Task UpdateProduct(Product product);
        public Task DeleteProduct(int id);
    }
}

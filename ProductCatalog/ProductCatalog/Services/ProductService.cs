using System.Collections.Generic;
using System.Threading.Tasks;
using ProductCatalog.Models;

namespace ProductCatalog.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(string id);
        Task<Product> CreateProductAsync(Product product);
        Task<Product> UpdateProductAsync(string id, Product product);
        Task<bool> DeleteProductAsync(string id);
    }
}
using ProductService.Models;
using ProductService.Repositories.Contracts;
using ProductService.Services.Contracts;

namespace ProductService.Services
{
    public class ProductApplicationService : IProductService
    {
        private readonly IProductRepository _repository;
        public ProductApplicationService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _repository.GetAllProductsAsync();
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _repository.GetProductByIdAsync(id);
        }

        public async Task AddProductAsync(Product product)
        {
            await _repository.AddProductAsync(product);
        }

        public async Task UpdateProductAsync(Product product)
        {
            await _repository.UpdateProductAsync(product);
        }

        public async Task DeleteProductAsync(int id)
        {
            await _repository.DeleteProductAsync(id);
        }
    }
}

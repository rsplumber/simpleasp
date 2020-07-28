using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.Controllers.Product.Create;
using WebApplication.Controllers.Product.Delete;
using WebApplication.Controllers.Product.Get;
using WebApplication.Controllers.Product.Update;
using WebApplication.Domain.Product.Model;
using WebApplication.Domain.Product.Repository;

namespace WebApplication.Domain.Product.Service
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<ProductEntity> CreateProductAsync(CreateProductRequest request)
        {
            var model = new ProductEntity()
            {
                Name = request.Name,Description = request.Description,Title =  request.Title
            };
            return await _repository.CreateAsync(model);
        }

        public async Task<ProductEntity> UpdateProductAsync(UpdateProductRequest request)
        {
            var model = new ProductEntity()
            {
                ProductId = request.ProductId ,Name = request.Name,Description = request.Description,Title =  request.Title
            };
            return await _repository.UpdateAsync(model);
        }

        public async Task<List<ProductEntity>> GetAllProducts(GetProductRequest request)
        {
            //we dont have any logic for request,like pagination or ...

            return await _repository.Get();
        }

        public async Task<ProductEntity> FindById(int id)
        {
            return await _repository.FindById(id);
        }

        public async Task<bool> DeleteProductAsync(DeleteProductRequest request)
        {
            var model = new ProductEntity()
            {
                ProductId = request.ProductId
            };
            return await _repository.DeleteAsync(model);
        }
    }
}
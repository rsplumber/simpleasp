using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.Controllers.Product.Create;
using WebApplication.Controllers.Product.Delete;
using WebApplication.Controllers.Product.Get;
using WebApplication.Controllers.Product.Update;
using WebApplication.Domain.Product.Model;

namespace WebApplication.Domain.Product.Service
{
    public interface IProductService
    {
        Task<ProductEntity> CreateProductAsync(CreateProductRequest request);
        
        Task<ProductEntity> UpdateProductAsync(UpdateProductRequest request);
        
        Task<List<ProductEntity>> GetAllProducts(GetProductRequest request);
        
        Task<ProductEntity> FindById(int id);
        
        Task<bool> DeleteProductAsync(DeleteProductRequest request);
        
    }
}
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebApplication.Domain.Context;
using WebApplication.Domain.Product.Model;

namespace WebApplication.Domain.Product.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MyDbContext _myDbContext;

        public ProductRepository(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public async Task<ProductEntity> CreateAsync(ProductEntity model)
        {
            var savedModel = _myDbContext.Add(model);
            await _myDbContext.SaveChangesAsync();
            return savedModel.Entity;
        }

        public async Task<bool> DeleteAsync(ProductEntity model)
        {
            _myDbContext.Remove(model);
            await _myDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<ProductEntity>> Get()
        {
            return  _myDbContext.Products
                .ToList();
        }

        public async Task<ProductEntity> UpdateAsync(ProductEntity model)
        {
            
            var savedModel = _myDbContext.Update(model);
            await _myDbContext.SaveChangesAsync();
            return savedModel.Entity;
        }

        public async Task<ProductEntity> FindById(int id)
        {
            return  _myDbContext.Products
                .First(p => p.ProductId == id);
        }
    }
}
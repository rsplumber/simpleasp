using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using WebApplication.Domain.Base;
using WebApplication.Domain.Product.Model;

namespace WebApplication.Domain.Product.Repository
{
    public interface IProductRepository:IBaseRepository<ProductEntity , int>
    {
       
    }
}
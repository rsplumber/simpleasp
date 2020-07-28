
using WebApplication.Controllers.Product.DTOs;

namespace WebApplication.Controllers.Category.Find
{
    public class FindProductResponse
    {
        public FindProductResponse(ProductDto product)
        {
            Product = product;
        }

        public ProductDto Product { get; set; }


    }
}
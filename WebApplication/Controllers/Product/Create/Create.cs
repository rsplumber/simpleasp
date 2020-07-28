using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nelibur.ObjectMapper;
using WebApplication.Controllers.Base;
using WebApplication.Controllers.Product.DTOs;
using WebApplication.Domain.Product.Service;

namespace WebApplication.Controllers.Product.Create
{
    [Route("/products")]
    public class Create : BaseController<CreateProductRequest, CreateProductResponse>
    {
        private readonly IProductService _productService;

        public Create(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public override async Task<ApiResponse<CreateProductResponse>> Response([FromBody] CreateProductRequest request)
        {
            var model = await _productService.CreateProductAsync(request);
            var dto = TinyMapper.Map<ProductDto>(model);
            
            return new ApiResponse<CreateProductResponse>(new CreateProductResponse(dto))
                .StatusCode(200)
                .Message("Successful");
        }
    }
}
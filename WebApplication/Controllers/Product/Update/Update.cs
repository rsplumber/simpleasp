﻿using System.Threading.Tasks;
 using Microsoft.AspNetCore.Mvc;
 using Nelibur.ObjectMapper;
 using WebApplication.Controllers.Base;
 using WebApplication.Controllers.Category.Find;
 using WebApplication.Controllers.Product.DTOs;
 using WebApplication.Domain.Product.Model;
 using WebApplication.Domain.Product.Service;

 namespace WebApplication.Controllers.Product.Update
{
    [Route("/products")]
    public class Update:BaseController<UpdateProductRequest,UpdateProductResponse>
    {
        
        private readonly IProductService _productService;

        public Update(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPatch]
        public override async Task<ApiResponse<UpdateProductResponse>> Response([FromForm]UpdateProductRequest request)
        {
            var model = await _productService.UpdateProductAsync(request);
            
            TinyMapper.Bind<ProductEntity, ProductDto>();
            var dto = TinyMapper.Map<ProductDto>(model);
            
            return new ApiResponse<UpdateProductResponse>( new UpdateProductResponse(dto))
                .StatusCode(200)
                .Message("Successful");
        }
    }
}
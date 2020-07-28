﻿using System.Threading.Tasks;
 using Microsoft.AspNetCore.Mvc;
 using Nelibur.ObjectMapper;
 using WebApplication.Controllers.Base;
 using WebApplication.Controllers.Category.Find;
 using WebApplication.Controllers.Product.DTOs;
 using WebApplication.Domain.Product.Service;

 namespace WebApplication.Controllers.Product.Find
{
    [Route("/products/{ProductId}")]
    public class Find:BaseController<FindProductRequest ,FindProductResponse>
    {

        private readonly IProductService _productService;

        public Find(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public override async Task<ApiResponse<FindProductResponse>> Response([FromRoute]FindProductRequest request)
        {
            var model = await _productService.FindById(request.productId);
            var dto = TinyMapper.Map<ProductDto>(model);
            
            return new ApiResponse<FindProductResponse>( new FindProductResponse(dto))
                .StatusCode(200)
                .Message("Successful");
        }
    }
}
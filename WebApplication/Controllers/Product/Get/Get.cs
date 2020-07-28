﻿using System.Linq;
 using System.Threading.Tasks;
 using Microsoft.AspNetCore.Mvc;
 using Nelibur.ObjectMapper;
 using WebApplication.Controllers.Base;
 using WebApplication.Controllers.Category.Find;
 using WebApplication.Controllers.Product.DTOs;
 using WebApplication.Domain.Product.Service;

 namespace WebApplication.Controllers.Product.Get
{
    [Route("/products")]
    public class Get :BaseController<GetProductRequest ,GetProductResponse>
    {
        private readonly IProductService _productService;

        public Get(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public override async Task<ApiResponse<GetProductResponse>> Response([FromQuery]GetProductRequest request)
        {
            var models = await _productService.GetAllProducts(request);
            var dtos = models.Select(entity => TinyMapper.Map<ProductDto>(entity)).ToList();

            return new ApiResponse<GetProductResponse>( new GetProductResponse(dtos))
                .StatusCode(200)
                .Message("Successful");
        }
    }
}
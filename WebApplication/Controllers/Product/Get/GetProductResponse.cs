﻿using System.Collections.Generic;
 using WebApplication.Controllers.Product.DTOs;

 namespace WebApplication.Controllers.Product.Get
{
    public class GetProductResponse
    {
        public List<ProductDto> ProductDtos;

        public GetProductResponse(List<ProductDto> productDtos)
        {
            ProductDtos = productDtos;
        }
    }
}
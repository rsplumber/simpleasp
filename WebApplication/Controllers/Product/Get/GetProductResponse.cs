﻿using System.Collections.Generic;
 using WebApplication.Controllers.Product.DTOs;

 namespace WebApplication.Controllers.Product.Get
{
    public class GetProductResponse
    {
        public List<ProductDto> Products { get; set; }

        public GetProductResponse(List<ProductDto> productDtos)
        {
            Products = productDtos;
        }
    }
}
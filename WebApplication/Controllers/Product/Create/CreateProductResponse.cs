﻿using WebApplication.Controllers.Product.DTOs;

 namespace WebApplication.Controllers.Product.Create
{
    public class CreateProductResponse
    {
        public ProductDto ProductDto { get; set; }

        public CreateProductResponse(ProductDto productDto)
        {
            ProductDto = productDto;
        }
    }
}
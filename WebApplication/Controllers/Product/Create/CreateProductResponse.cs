﻿using WebApplication.Controllers.Product.DTOs;

 namespace WebApplication.Controllers.Product.Create
{
    public class CreateProductResponse
    {
        public ProductDto Product { get; set; }

        public CreateProductResponse(ProductDto productDto)
        {
            Product = productDto;
        }
    }
}
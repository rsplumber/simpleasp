﻿using WebApplication.Controllers.Product.DTOs;

 namespace WebApplication.Controllers.Product.Update
{
    public class UpdateProductResponse
    {
        
        public ProductDto ProductDto { get; set; }

        public UpdateProductResponse(ProductDto productDto)
        {
            ProductDto = productDto;
        }
    }
}
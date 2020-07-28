﻿using WebApplication.Controllers.Product.DTOs;

 namespace WebApplication.Controllers.Product.Update
{
    public class UpdateProductResponse
    {
        
        public ProductDto Product { get; set; }

        public UpdateProductResponse(ProductDto productDto)
        {
            Product = productDto;
        }
    }
}
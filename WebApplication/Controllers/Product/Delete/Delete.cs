﻿using System.Threading.Tasks;
 using Microsoft.AspNetCore.Mvc;
 using WebApplication.Controllers.Base;
 using WebApplication.Controllers.Product.Create;
 using WebApplication.Domain.Product.Service;

 namespace WebApplication.Controllers.Product.Delete
{
    [Route("/products/{ProductId}")]
    public class Delete:BaseController<DeleteProductRequest,DeleteProductResponse>
    {
        
        private readonly IProductService _productService;

        public Delete(IProductService productService)
        {
            _productService = productService;
        }

        [HttpDelete]
        public override async Task<ApiResponse<DeleteProductResponse>> Response([FromRoute]DeleteProductRequest request)
        {
            var deleted = await _productService.DeleteProductAsync(request);
            
            return new ApiResponse<DeleteProductResponse>(new DeleteProductResponse(deleted))
                .StatusCode(200)
                .Message("Successful");
        }
    }
}
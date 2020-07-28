﻿namespace WebApplication.Controllers.Product.Delete
{
    public class DeleteProductResponse
    {
        public bool Deleted { get; set; }

        public DeleteProductResponse(bool deleted)
        {
            Deleted = deleted;
        }
    }
}
﻿namespace WebApplication.Controllers.Product.Delete
{
    public class DeleteProductResponse
    {
        public bool deleted { get; set; }

        public DeleteProductResponse(bool deleted)
        {
            this.deleted = deleted;
        }
    }
}
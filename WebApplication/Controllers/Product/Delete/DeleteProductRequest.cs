﻿using System.ComponentModel.DataAnnotations;

 namespace WebApplication.Controllers.Product.Delete
{
    public class DeleteProductRequest
    {

        [Required]
        public int ProductId { get; set; }
    }
}
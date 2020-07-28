﻿using System.ComponentModel.DataAnnotations;

 namespace WebApplication.Controllers.Product.Update
{
    public class UpdateProductRequest
    {

        [Required]
        public int ProductId { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }
    }
}
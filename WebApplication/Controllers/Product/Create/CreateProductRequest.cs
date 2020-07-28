﻿using System.ComponentModel.DataAnnotations;

 namespace WebApplication.Controllers.Product.Create
{
    public class CreateProductRequest
    {

        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }
    }
}
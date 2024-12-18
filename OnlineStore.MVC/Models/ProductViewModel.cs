﻿using System.ComponentModel.DataAnnotations;

namespace OnlineStore.MVC.Models
{
    public class ProductViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public ICollection<string> Images {  get; set; }
    }
}

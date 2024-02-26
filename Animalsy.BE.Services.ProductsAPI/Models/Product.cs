﻿using System.ComponentModel.DataAnnotations;

namespace Animalsy.BE.Services.ProductsAPI.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid VendorId { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(1000)]
        public string Description { get; set; }
        [Required, MaxLength(20)]
        public string Category { get; set; }
        [Required, MaxLength(20)]
        public string SubCategory { get; set; }
        [Required]
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public decimal PromoPrice { get; set; }
        [Required]
        public TimeSpan Duration { get; set; }
        public IEnumerable<string> Services { get; set; }
    }
}

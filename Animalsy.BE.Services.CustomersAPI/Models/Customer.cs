﻿using System.ComponentModel.DataAnnotations;

namespace Animalsy.BE.Services.CustomersAPI.Models
{
    public class Customer
    {
        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(20)]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(20)]
        public string LastName { get; set; } = string.Empty;

        [Required, MaxLength(20)]
        public string City { get; set; } = string.Empty;

        [MaxLength(40)]
        public string Street { get; set; } = string.Empty;

        [MaxLength(5)]
        public string Building { get; set; } = string.Empty;

        [MaxLength(5)]
        public string? Flat { get; set; }

        [MaxLength(6)]
        public string PostalCode { get; set; } = string.Empty;

        [MaxLength(9)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required, MaxLength(50)] 
        public string EmailAddress { get; set; } = string.Empty;
    }
}

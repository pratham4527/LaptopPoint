﻿using System.ComponentModel.DataAnnotations;

namespace laptopProj.Models
{
    public class Laptops
    {
        [Key]
        public int? Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Imgurl { get; set; }
        [Required]
        public int? Price { get; set; }
    }
}

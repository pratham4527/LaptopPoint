using System.ComponentModel.DataAnnotations;

namespace laptopProj.Models
{
    public class Cart
    {
        [Key]
        public int? P_Id { get; set; }
        [Required]
        public string? P_Name { get; set; }
        [Required]
        public int? Price { get; set; }

        [Range(1, 100, ErrorMessage = "Quantity must be between 1 and 100.")]
        public int Quantity { get; set; }

    }
}

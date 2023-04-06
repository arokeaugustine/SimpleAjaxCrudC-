
using System.ComponentModel.DataAnnotations;

namespace CodeSimpleCrud.Models
{
    public class Product
    {
        [Key]
        [MaxLength(6)]
        public string? Code { get; set; }


        [MaxLength(75)]
        public string? Name { get; set; }

        [MaxLength(225)]
        public string? Description { get; set; }

        [MaxLength(15)]
        public string? Category { get; set; }

        [Range(5, 1500000)]
        public float Cost { get; set; }

        [Range(5, 30000)]
        public float Price { get; set; }

        [MaxLength(500)]
        public string?   ImageUrl { get; set; }
    }
}

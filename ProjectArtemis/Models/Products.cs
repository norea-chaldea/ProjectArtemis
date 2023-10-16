using System.ComponentModel.DataAnnotations;

namespace ProjectArtemis.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        public bool InStock { get; set; }

        [Range(0, short.MaxValue)]
        public short Quantity { get; set; }
    }
}
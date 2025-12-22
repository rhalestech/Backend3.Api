using System.ComponentModel.DataAnnotations;

namespace Backend3.Api.Dtos
{
    public class ProductUpdateDto
    {
        [Required]
        public string Name { get; set; }

        [Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }
    }
}

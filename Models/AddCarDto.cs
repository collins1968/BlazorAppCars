using System.ComponentModel.DataAnnotations;

namespace BlazorAppCars.Models
{
    public class AddCarDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string Color { get; set; } = string.Empty;

        [Required]
        public string Image { get; set; } = string.Empty;

        [Required]
        public int Price { get; set; }

        public List<Make> Makes { get; set; } = new List<Make>();

    }

    public class Make
    {
        public int Id { get; set; }
        [Required]
        public string ModelName { get; set; }
    }
}

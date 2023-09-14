namespace BlazorAppCars.Models
{
    public class CarDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Color { get; set; } = string.Empty;

        public string Image { get; set; } = string.Empty;

        public int Price { get; set; }
    }
}

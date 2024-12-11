namespace FoodMenuWebApp.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string ImageUrl { get; set; } = String.Empty;
        public double Price { get; set; }
        public List<DishIngradient>? DishIngradients { get; set; }
    }
}

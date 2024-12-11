namespace FoodMenuWebApp.Models
{
    public class Ingradient
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public List<DishIngradient>? DishIngradients { get; set; }
    }
}

namespace FoodMenuWebApp.Models
{
    public class DishIngradient
    {
        public int DishId { get; set; }
        public Dish? Dish { get; set; }
        public int IngradientId { get; set; }
        public Ingradient? Ingradient { get; set; }
    }
}

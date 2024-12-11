using Microsoft.EntityFrameworkCore;

namespace FoodMenuWebApp.Models
{
    public class MenuContext : DbContext
    {
        public MenuContext(DbContextOptions<MenuContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishIngradient>().HasKey(di => new
            {
                di.DishId,
                di.IngradientId
            });

            modelBuilder.Entity<DishIngradient>().HasOne(d => d.Dish).WithMany(di => di.DishIngradients).HasForeignKey(d => d.DishId);
            modelBuilder.Entity<DishIngradient>().HasOne(i => i.Ingradient).WithMany(di => di.DishIngradients).HasForeignKey(i => i.IngradientId);

            modelBuilder.Entity<Dish>().HasData(
                new Dish { Id = 1, Name = "Margherita", Price = 7.50, ImageUrl = "https://au.ooni.com/cdn/shop/articles/20220211142645-margherita-9920.jpg?crop=center&height=800&v=1662539926&width=800" },
                new Dish { Id = 2, Name = "Pepperoni", Price = 8.50, ImageUrl = "https://i0.wp.com/daddioskitchen.com/wp-content/uploads/2023/01/IMG-5299.jpg?fit=3024%2C3024&ssl=1" },
                new Dish { Id = 3, Name = "Vegetarian", Price = 9.00, ImageUrl = "https://cdn.loveandlemons.com/wp-content/uploads/2023/02/vegetarian-pizza.jpg" }
                );

            modelBuilder.Entity<Ingradient>().HasData(
                new Ingradient { Id = 1, Name = "Tomato Sauce"},
                new Ingradient { Id = 2, Name = "Mozzarella" },
                new Ingradient { Id = 3, Name = "Pepperoni" },
                new Ingradient { Id = 4, Name = "Paprika" },
                new Ingradient { Id = 5, Name = "Mushroom" }
                );

            modelBuilder.Entity<DishIngradient>().HasData(
                new DishIngradient { DishId = 1, IngradientId = 1 },
                new DishIngradient { DishId = 1, IngradientId = 2 },
                new DishIngradient { DishId = 2, IngradientId = 1 },
                new DishIngradient { DishId = 2, IngradientId = 2 },
                new DishIngradient { DishId = 2, IngradientId = 3 },
                new DishIngradient { DishId = 3, IngradientId = 4 },
                new DishIngradient { DishId = 3, IngradientId = 5 }
                );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Ingradient> Ingradients { get; set; }
        public DbSet<DishIngradient> DishIngradients { get; set; }
    }
}

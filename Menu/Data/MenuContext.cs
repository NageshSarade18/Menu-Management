using Microsoft.EntityFrameworkCore;
using Menu.Models;
namespace Menu.Data
{
    public class MenuContext : DbContext
    {
        public MenuContext(DbContextOptions<MenuContext> options) : base(options)
        {

        }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<DishIngredient> DishIngredients { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishIngredient>().HasKey(di => new 
            {
                di.DishId, di.IngredientId
            });
            modelBuilder.Entity<DishIngredient>().HasOne(d => d.Dish).WithMany(di => di.DishIngredient).HasForeignKey(d => d.DishId);

            modelBuilder.Entity<DishIngredient>().HasOne(i =>i.Ingredient).WithMany(di => di.DishIngredient).HasForeignKey(i =>i.IngredientId);


            //modelBuilder.Entity<Dish>().HasData(
            //    new Dish { Id=1,Name="Margherita",price=7.5,ImageUrl= "https://i0.wp.com/cookingitalians.com/wp-content/uploads/2024/11/Margherita-Pizza.jpg?fit=1344%2C768&ssl=1" }
            //    );

            //modelBuilder.Entity<Ingredient>().HasData(
            //    new Ingredient {Id=1,Name="tomato Sauce" },
            //     new Ingredient { Id = 2, Name = "Mozzarella" }
            //    );

            //modelBuilder.Entity<DishIngredient>().HasData(
            //    new DishIngredient {DishId=1,IngredientId=1 },
            //    new DishIngredient { DishId = 2, IngredientId = 2 }
            //    );


            //base.OnModelCreating(modelBuilder);
        }
      
    }
}

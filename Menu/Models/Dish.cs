namespace Menu.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public decimal price { get; set; }
        public List <DishIngredient>? DishIngredient {get;set;}
    }
}

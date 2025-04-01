namespace CookBook.Entities
{
    public class Food
    {
        public int Id { get; set; }
        public String foodName { get; set; }
        double calories { get; set; }
        public virtual ICollection<FoodIngredient> FoodIngredients { get; set; } = new List<FoodIngredient>();



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Entities
{
     public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double CaloriesPer100g { get; set; } 
        public ICollection<FoodIngredient> FoodIngredients { get; set; } = new List<FoodIngredient>();
    }
}

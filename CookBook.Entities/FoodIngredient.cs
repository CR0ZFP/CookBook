using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Entities
{
    public class FoodIngredient
    {
        public int FoodId { get; set; }
        public Food Food { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
        public double Grams { get; set; }
    }
}

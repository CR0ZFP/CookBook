using CookBook.Entities.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Entities
{
    public class FoodIngredient : 
    {
        public string FoodId { get; set; }
        public Food Food { get; set; }
        public string IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
        public double Grams { get; set; }
    }
}

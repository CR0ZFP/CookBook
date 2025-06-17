using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Entities.Dto
{
    public class IngredientInFoodDto
    {
        public string Name { get; set; } = "";
        public double Grams { get; set; } = 0.0;
        public double CaloriesPer100g { get; set; } = 0.0;
    }
}

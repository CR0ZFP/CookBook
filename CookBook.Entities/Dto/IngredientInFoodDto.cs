using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Entities.Dto
{
    public class IngredientInFoodDto
    {
        public string Name { get; set; }
        public double Gramms { get; set; }
        public double CaloriesPer100g { get; set; }
    }
}

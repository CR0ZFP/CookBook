using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Entities.Dto
{
    public class FoodViewDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Calories { get; set; }
        public List<IngredientInFoodDto> Ingredients { get; set; }
    }
}

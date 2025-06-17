using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Entities.Dto
{
    public class FoodCreateDto
    {
        public string FoodName { get; set; } = "";
        public List<FoodCreateIngredientDto> FoodIngredients { get; set; } = new();
    }
}

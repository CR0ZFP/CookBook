using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Entities.Dto
{
    public class FoodCreateDto
    {
        public string Name { get; set; }
        public List<FoodCreateIngredientDto> Ingredients { get; set; } = new();
    }
}

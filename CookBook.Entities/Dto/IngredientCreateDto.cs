using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Entities.Dto
{
    public class IngredientCreateDto
    {
        public string Id { get; set; } = string.Empty;
        public string name { get; set; } = string.Empty;
        public double CaloriesPer100g { get; set; }
    }
}

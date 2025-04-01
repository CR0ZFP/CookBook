using CookBook.Entities.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Entities
{
     public class Ingredient : IIdEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [StringLength (250)]
        public string Name { get; set; }
        public double CaloriesPer100g { get; set; } 
        public ICollection<FoodIngredient> FoodIngredients { get; set; } = new List<FoodIngredient>();
    }
}

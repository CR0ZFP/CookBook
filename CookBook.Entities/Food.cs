using CookBook.Entities.Helpers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace CookBook.Entities
{
    public class Food : IIdEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } = string.Empty;
        [StringLength(250)]
        public string FoodName { get; set; } = string.Empty;
        double Calories { get; set; }
        public virtual ICollection<FoodIngredient> FoodIngredients { get; set; } = new List<FoodIngredient>();



    }
}

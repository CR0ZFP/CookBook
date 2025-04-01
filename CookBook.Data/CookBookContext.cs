using CookBook.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Data
{
    public class CookBookContext : IdentityDbContext
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<Ingredient> Ingedients { get; set; }

        public CookBookContext (DbContextOptions<CookBookContext> opt) : base (opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FoodIngredient>()
                .HasKey(x => new  { x.FoodId, x.IngredientId });

            modelBuilder.Entity<FoodIngredient>()
                .HasOne(x => x.Food)
                .WithMany(y => y.FoodIngredients)
                .HasForeignKey(x => x.FoodId);

            modelBuilder.Entity<FoodIngredient>()
                .HasOne(x => x.Ingredient)
                .WithMany(y => y.FoodIngredients)
                .HasForeignKey(x => x.IngredientId);

            modelBuilder.Entity<Ingredient>().HasData(
             new Ingredient { Id = "1", Name = "Salt", CaloriesPer100g = 0 },
             new Ingredient { Id = "2", Name = "Sugar", CaloriesPer100g = 400 },
             new Ingredient { Id = "3", Name = "Chicken Breast", CaloriesPer100g = 165 },
             new Ingredient { Id = "4", Name = "Pasta", CaloriesPer100g = 350 }
         );

            modelBuilder.Entity<Food>().HasData(
                new Food { Id = "1", FoodName = "Bolognese" },
                new Food { Id = "2", FoodName = "Fried Chicken" }
            );

            modelBuilder.Entity<FoodIngredient>().HasData(
                new FoodIngredient { FoodId = "1", IngredientId = "4", Grams = 100 }, 
                new FoodIngredient { FoodId = "1", IngredientId = "2", Grams = 10 },  
                new FoodIngredient { FoodId = "2", IngredientId = "3", Grams = 150 }, 
                new FoodIngredient { FoodId = "2", IngredientId = "1", Grams = 5 }    
            );
        }
    }
}

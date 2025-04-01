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
    class CookBookContext : IdentityDbContext
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

           
        }
    }
}

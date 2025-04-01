using AutoMapper;
using AutoMapper.Configuration.Conventions;
using CookBook.Entities;
using CookBook.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Logic.Dto
{
    public class DtoProvider
    {
        public Mapper Mapper { get; }

        public DtoProvider()
        {
            Mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Food, FoodViewDto>().AfterMap((src, dest) =>
                {
                    dest.Calories = src.FoodIngredients.Sum(x => x.Grams * (x.Ingredient.CaloriesPer100g / 100.0));
                });
                cfg.CreateMap<FoodCreateDto, Food>();
                cfg.CreateMap<IngredientInFoodDto, Ingredient>();
                cfg.CreateMap<FoodCreateIngredientDto, Ingredient>();
                cfg.CreateMap<Ingredient, IngredientViewDto>();

            }));
        }
    }
}

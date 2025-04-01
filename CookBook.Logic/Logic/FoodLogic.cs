using AutoMapper;
using CookBook.Data.Repositories;
using CookBook.Entities;
using CookBook.Entities.Dto;
using CookBook.Logic.Dto;
using Microsoft.EntityFrameworkCore;


namespace CookBook.Logic.Logic
{
    public class FoodLogic
    {
        public Repository<Food> repository;
        public Mapper mapper;

        public FoodLogic (Repository<Food> repository, DtoProvider provider) 
        {
            this.repository = repository;
            mapper = provider.Mapper;
        }

        public IEnumerable<FoodViewDto> Read()
        {
            var foods = repository.GetContext()
            .Foods
            .Include(f => f.FoodIngredients)
            .ThenInclude(fi => fi.Ingredient)
            .ToList();

            return foods.Select(food => mapper.Map<FoodViewDto>(food)).ToList();
        }

        public void Create (FoodCreateDto dto)
        {
            var food = mapper.Map<Food>(dto);
            repository.Create(food);
        }

        public void Delete (string id)
        {
            repository.DeleteById(id);
        }

        public void Update (string id, FoodCreateDto dto)
        {
            var foodToUpdate = repository.FindById(id);
            mapper.Map(dto, foodToUpdate);
            repository.Update(foodToUpdate);
        }

        
    }
}

using AutoMapper;
using CookBook.Data.Repositories;
using CookBook.Entities.Dto;
using CookBook.Entities;
using CookBook.Logic.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Logic.Logic
{
    public class IngredientLogic
    {
        public Repository<Ingredient> repository;
        public Mapper mapper;

        public IngredientLogic(Repository<Ingredient> repository, DtoProvider provider)
        {
            this.repository = repository;
            mapper = provider.Mapper;
        }

        public IEnumerable<IngredientViewDto> Read()
        {
            return repository.GetAll().Select(t => mapper.Map<IngredientViewDto>(t));
        }

        public void Create(IngredientCreateDto dto)
        {
            var ingredient = mapper.Map<Ingredient>(dto);
            repository.Create(ingredient);
        }

        public void Delete(string id)
        {
            repository.DeleteById(id);
        }

        public void Update(string id, FoodCreateIngredientDto dto)
        {
            var ingredientToUpdate = repository.FindById(id);
            mapper.Map(dto, ingredientToUpdate);
            repository.Update(ingredientToUpdate);
        }
    }
}

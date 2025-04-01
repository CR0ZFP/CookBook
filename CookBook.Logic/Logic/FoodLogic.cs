﻿using AutoMapper;
using CookBook.Data.Repositories;
using CookBook.Entities;
using CookBook.Entities.Dto;
using CookBook.Logic.Dto;


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

        public IEnumerable<FoodViewDto> Read ()
        {
            return repository.GetAll().Select(t =>mapper.Map<FoodViewDto>(t));
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

        public void Update (string id)
        {
            var foodToUpdate = repository.FindById(id);
            repository.Update(foodToUpdate);
        }
    }
}

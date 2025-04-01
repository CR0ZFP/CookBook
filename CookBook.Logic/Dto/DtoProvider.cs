using AutoMapper;
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
                cfg.CreateMap<Food, FoodViewDto>();
                cfg.CreateMap<FoodCreateDto, Food>();
            }));
        }
    }
}

using Microsoft.EntityFrameworkCore;
using CookBook.Data;
using CookBook.Logic;
using CookBook.Logic.Dto;
using CookBook.Data.Repositories;
using CookBook.Logic.Dto;
using CookBook.Logic.Logic;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using CookBook.Data;

namespace CookBook.Endpoint
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<CookBookContext>(options =>
            {
                options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=CookBookDb;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True");
            });


            builder.Services.AddScoped(typeof(Repository<>));

            //Logic osztályok és mapper
            builder.Services.AddScoped<DtoProvider>();
            builder.Services.AddScoped<FoodLogic>();
            builder.Services.AddScoped<IngredientLogic>();



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
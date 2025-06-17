using CookBook.Entities.Dto;
using CookBook.Logic.Logic;
using Microsoft.AspNetCore.Mvc;

namespace CookBook.Endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IngredientController : ControllerBase
    {
        IngredientLogic logic;

        public IngredientController(IngredientLogic logic)
        {
            this.logic = logic;
        }

        [HttpGet]
        public IEnumerable<IngredientViewDto> Get()
        {
            return this.logic.Read();
        }

        [HttpPost]
        public void Post(IngredientCreateDto dto)
        {
            this.logic.Create(dto);
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            this.logic.Delete(id);
        }

        [HttpPut("{id}")]
        public void Upgdate(string id, [FromBody] FoodCreateIngredientDto dto)
        {
            this.logic.Update(id, dto);
        }

    }
}

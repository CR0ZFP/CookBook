using CookBook.Entities.Dto;
using CookBook.Logic.Logic;
using Microsoft.AspNetCore.Mvc;


namespace CookBook.Endpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class FoodController : ControllerBase
{
    FoodLogic logic;

    public FoodController(FoodLogic logic)
    {
        this.logic = logic;
    }

    [HttpGet]
    public IEnumerable<FoodViewDto> Get()
    {
        return this.logic.Read();
    }

    [HttpPost]
    public void Post(FoodCreateDto dto)
    {
        this.logic.Create(dto);
    }

    [HttpDelete("{id}")]
    public void Delete(string id)
    {
        this.logic.Delete(id);
    }

    [HttpPut("{id}")]
    public void Upgdate(string id, [FromBody] FoodCreateDto dto)
    {
        this.logic.Update(id, dto);
    }

}

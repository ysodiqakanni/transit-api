using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace transit_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllCities()
        {
            var list = new List<object>()
            {
                new
                {
                    id = 1,
                    name = "Houston"
                },
                new
                {
                    id = 2,
                    name = "Austin"
                },
                new
                {
                    id = 3,
                    name = "Dallas"
                }
            };
            return Ok(list);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCityById(int id)
        {
            return Ok(new { 
                id,
                name = "Tampa"
            });
        }

    }
}

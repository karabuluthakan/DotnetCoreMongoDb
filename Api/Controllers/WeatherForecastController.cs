using System.Linq;
using Api.DataAccess.Abstract;
using Api.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastDal weatherForecastDal;

        public WeatherForecastController(IWeatherForecastDal weatherForecastDal)
        {
            this.weatherForecastDal = weatherForecastDal;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = weatherForecastDal.Get();
            if (result == null)
            {
                return BadRequest("Not found");
            }

            return Ok(result.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var result = weatherForecastDal.GetByIdAsync(id).Result;
            if (result == null)
            {
                return BadRequest("Not found");
            }

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] WeatherForecast data)
        {
            var result = weatherForecastDal.AddAsync(data).Result;
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, [FromBody] WeatherForecast data)
        {
            var result = weatherForecastDal.UpdateAsync(id, data).Result;
            if (result == null)
            {
                return BadRequest("Not found");
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var result = weatherForecastDal.DeleteAsync(id).Result;
            if (result == null)
            {
                return BadRequest("Not found");
            }

            return NoContent();
        }
    }
}
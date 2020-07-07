using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySQLConnectionWithDotNetCore.Models.DBModels;

namespace MySQLConnectionWithDotNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private weatherContext _weather;

        

        public WeatherForecastController(weatherContext weather)
        {
            this._weather = weather;
        }

        [HttpGet]
        public ActionResult<IEnumerable<weatherContext>> Get()
        {
            var turkey = _weather.Turkey.ToList();
            return Ok(turkey);

        }

        [HttpPost("/[controller]/adder")]
        public async Task<IActionResult> Adder([FromBody] Turkey turkey)
        {
            _weather.Add(turkey);
            await _weather.SaveChangesAsync();
            return Ok();
        }


    }
}

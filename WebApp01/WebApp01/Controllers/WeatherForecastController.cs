using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace WebApp01.Controllers
{
    [ApiController]
    [Route("WeatherForecast")]

    public class WeatherForecastController : ControllerBase
    {


        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ValuesHolder _holder;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ValuesHolder holder)
        {
            _logger = logger;
            _holder = holder;
        }


        [HttpPost("create")]
        public string Create()

        {
            _holder.Add(new ValuesHolder() { Id = 1, Date = DateTime.Now, TemperatureC = 20 });

            return "Add new value";
        }

        [HttpGet("read")]
        public void Read()

        {
            _holder.Get();
        }

        [HttpPut("update")]
        public string Update([FromQuery] int stringsToUpdate,
        [FromQuery] int newValue)
        {

            for (int i = 0; i < _holder.Values.Count; i++)
            {
                if (_holder.Values[i].Id == stringsToUpdate)
                    _holder.Values[i].Id = newValue;
            }
            return "Update Complete";
        }

        [HttpDelete("delete")]
        public string Delete([FromQuery] int id, ValuesHolder valuesholder)
        {
            if (_holder.Id == id)
            {
                _holder.Values.Remove(valuesholder);
                return "Delete Complete";

            }
            else
            {
                return null;
            }
        }
    }
}



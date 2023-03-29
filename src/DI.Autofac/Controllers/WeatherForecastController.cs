using DI.Autofac.Weather;
using Microsoft.AspNetCore.Mvc;

namespace DI.Autofac.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly IWeatherForecaster _weatherForecaster;

        public WeatherForecastController(IWeatherForecaster weatherForecaster)
        {
            _weatherForecaster = weatherForecaster;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return _weatherForecaster.Forecast();
        }
    }
}
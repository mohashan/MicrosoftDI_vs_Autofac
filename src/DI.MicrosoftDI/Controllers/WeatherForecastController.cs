using DI.MicrosoftDI.Weather;
using Microsoft.AspNetCore.Mvc;

namespace DI.MicrosoftDI.Controllers
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
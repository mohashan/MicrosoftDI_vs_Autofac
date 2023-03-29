namespace DI.Autofac.Weather
{
    public interface IWeatherForecaster
    {
        IEnumerable<WeatherForecast> Forecast();
    }

    public class WeatherForecaster : IWeatherForecaster
    {
        private readonly DateTime _date=DateTime.Now;
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public IEnumerable<WeatherForecast> Forecast()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)],
                CreationDateTime = _date,
            })
            .ToArray();
        }
    }

    
}
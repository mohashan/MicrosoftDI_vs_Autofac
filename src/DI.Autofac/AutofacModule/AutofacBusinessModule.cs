using Autofac;
using DI.Autofac.Weather;

namespace DI.Autofac.AutofacModule
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<WeatherForecaster>().As<IWeatherForecaster>().SingleInstance();
        }
    }
}

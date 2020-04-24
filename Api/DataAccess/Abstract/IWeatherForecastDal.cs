using Api.Entities.Concrete;

namespace Api.DataAccess.Abstract
{
    public interface IWeatherForecastDal : IRepository<WeatherForecast, string>
    {
    }
}
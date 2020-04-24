using Api.DataAccess.Abstract;
using Api.Entities.Concrete;
using Api.Utilities.AppSettings;
using Microsoft.Extensions.Options;

namespace Api.DataAccess.Concrete
{
    public class WeatherForecastDal : MongoRepositoryBase<WeatherForecast>, IWeatherForecastDal
    {
        public WeatherForecastDal(IOptions<MongoDbSettings> options) : base(options)
        {
        }
    }
}
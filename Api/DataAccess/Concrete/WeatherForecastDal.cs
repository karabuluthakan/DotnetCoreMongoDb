using Api.DataAccess.Abstract;
using Api.Entities.Concrete;
using Api.Utilities.AppSettings;
using Microsoft.Extensions.Options;

namespace Api.DataAccess.Concrete
{
    public class WeatherForecastMongoDbDal : MongoDbRepositoryBase<WeatherForecast>, IWeatherForecastDal
    {
        public WeatherForecastMongoDbDal(IOptions<MongoDbSettings> options) : base(options)
        {
        }
    }
}

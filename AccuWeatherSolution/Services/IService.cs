using AccuWeatherSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccuWeatherSolution.Services
{
    public interface IService {
        Task<City[]> GetLocations(string locationName);
        Task<CityInfo.Information[]> GetNeighbours(string cityKey);
        Task<Forecast> GetForecast(string cityKey);
        Task<GeopositionClass> GetGeolocation(string cityKey);
        Task<Historical[]> GetHistorical(string cityKey);
        Task<ActivityFun[]> GetActivity(string cityKey);


    }
}

using AccuWeatherSolution.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AccuWeatherSolution.Services
{
    internal class Service
    {
        private const string base_url = "http://dataservice.accuweather.com";
        private const string autocomplete_endpoint = "locations/v1/cities/autocomplete?apikey={0}&q={1}&language={2}";
        private const string neighbour_endpoint = "locations/v1/cities/neighbors/{0}?apikey={1}";
        private const string forecast_endpoint = "forecasts/v1/daily/1day/{0}?apikey={1}";
        private const string geolocation_endpoint = "locations/v1/{0}?apikey={1}";
        private const string historical_endpoint = "currentconditions/v1/{0}/historical/24?apikey={1}&language={2}";
        private const string activity_endpoint = "indices/v1/daily/1day/{0}?apikey={1}";


        //static string api_key = "fczx5bWlQev7L9f8AKB5FXRike7Y31Xw";
        //static string api_key = "Q8lCuOk81DPfnkBxm6xyQOZriDn98i6t";
       static string api_key = "2Nd1oGlrvP56QGlxNnTnA3AMqryjqEPi";
       static  string language = "pl";

        public Service()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory());

            var configuration = builder.Build();


        }

        public async Task<City[]> GetLocations(string locationName)
        {
            string uri = base_url + "/" + string.Format(autocomplete_endpoint, api_key, locationName, language);
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(uri);
                string json = await response.Content.ReadAsStringAsync();
                City[] cities = JsonConvert.DeserializeObject<City[]>(json);
                return cities;

            }
        }


        public async Task<CityInfo.Information[]> GetNeighbours(string cityKey)
        {
            string uri = base_url + "/" + string.Format(neighbour_endpoint,cityKey,api_key);
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(uri);
                string json = await response.Content.ReadAsStringAsync();
                CityInfo.Information[] cities = JsonConvert.DeserializeObject<CityInfo.Information[]>(json);
                return cities;

            }
        }

        public async Task<Forecast> GetForecast(string cityKey)
        {
            string uri = base_url + "/" + string.Format(forecast_endpoint, cityKey, api_key);
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(uri);
                string json = await response.Content.ReadAsStringAsync();
                Forecast forecast = JsonConvert.DeserializeObject<Forecast>(json);
                return forecast;

            }
        }

        public async Task<GeopositionClass> GetGeolocation(string cityKey)
        {
            string uri = base_url + "/" + string.Format(geolocation_endpoint, cityKey, api_key);
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(uri);
                string json = await response.Content.ReadAsStringAsync();
                GeopositionClass geoposition = JsonConvert.DeserializeObject<GeopositionClass>(json);
                return geoposition;

            }
        }

        public async Task<Historical[]> GetHistorical(string cityKey)
        {
            string uri = base_url + "/" + string.Format(historical_endpoint, cityKey, api_key, language);
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(uri);
                string json = await response.Content.ReadAsStringAsync();
                Historical[] historical = JsonConvert.DeserializeObject<Historical[]>(json);
                return historical; ;

            }
        }


        public async Task<ActivityFun[]> GetActivity(string cityKey)
        {
            string uri = base_url + "/" + string.Format(activity_endpoint, cityKey, api_key, language);
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(uri);
                string json = await response.Content.ReadAsStringAsync();
                ActivityFun[] activities = JsonConvert.DeserializeObject<ActivityFun[]>(json);
                return activities; ;

            }
        }


    }
} 


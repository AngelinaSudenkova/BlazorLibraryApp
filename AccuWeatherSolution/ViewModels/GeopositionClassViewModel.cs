using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccuWeatherSolution.Models;

namespace AccuWeatherSolution.ViewModels
{
        public class GeopositionClassViewModel
    {
        public string latitude { get; set; }
        public string longitude { get; set; }

        public GeopositionClassViewModel(GeopositionClass geoposition) {
          longitude =  "Longtitude: " + geoposition.GeoPosition.Longitude + " \n ";
          latitude =    "Latitude: " + geoposition.GeoPosition.Latitude + " \n ";
        }
    }
}

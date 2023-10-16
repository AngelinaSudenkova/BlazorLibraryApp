using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccuWeatherSolution.Models
{
  

        public class Historical
        {
            public DateTime LocalObservationDateTime { get; set; }
            public int EpochTime { get; set; }
            public string WeatherText { get; set; }
            public int WeatherIcon { get; set; }
            public bool HasPrecipitation { get; set; }
            public object PrecipitationType { get; set; }
            public bool IsDayTime { get; set; }
            public Temperature1 Temperature { get; set; }
            public string MobileLink { get; set; }
            public string Link { get; set; }
        }

        public class Temperature1
        {
            public Metric Metric { get; set; }
            public Imperial Imperial { get; set; }
        }

        public class Metric1
        {
            public float Value { get; set; }
            public string Unit { get; set; }
            public int UnitType { get; set; }
        }

        public class Imperial1
        {
            public float Value { get; set; }
            public string Unit { get; set; }
            public int UnitType { get; set; }
        }

    }


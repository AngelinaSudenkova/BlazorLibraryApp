using AccuWeatherSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccuWeatherSolution.ViewModels
{
    public class NeighboursViewModel
    {
        public string LocalizedName { get; set; }

        public NeighboursViewModel(CityInfo.Information city)
        {
            LocalizedName = city.LocalizedName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using AccuWeatherSolution.Models;

namespace AccuWeatherSolution.ViewModels
{
    public class HistoricalViewModel
    {
        public string Facts { get; set; }

        public HistoricalViewModel(Historical historical)
        {
            Facts = historical.WeatherText + "\n";
        }
    }
}

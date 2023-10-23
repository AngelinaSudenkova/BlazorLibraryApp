using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccuWeatherSolution.Models;

namespace AccuWeatherSolution.ViewModels
{
    public class ForecastViewModel
    {
        public string severity {  get; set; }
        public string headline { get; set; }
        public string maxTemp { get; set; }
        public string minTemp { get; set; }

        public ForecastViewModel(Forecast forecast) {
            severity = "Severity level: " + forecast.Headline.Severity + "\n"; ;
            headline = forecast.Headline.Text + "\n";
            maxTemp = "Max temperatura: " + forecast.DailyForecasts[0].Temperature.Maximum.Value + forecast.DailyForecasts[0].Temperature.Maximum.Unit + "\n";
            minTemp = "Min temperatura: " + forecast.DailyForecasts[0].Temperature.Minimum.Value + forecast.DailyForecasts[0].Temperature.Minimum.Unit + "\n";


        }
    }
}

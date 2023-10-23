using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccuWeatherSolution.Models;

namespace AccuWeatherSolution.ViewModels
{
        public class ActivityFunViewModel
    {
        public string ActivityName { get; set; }
        public string ActivityValue{ get; set; }

        public string ActivityInfo { get; }

        public ActivityFunViewModel(ActivityFun activity ) {
            ActivityName = activity.Name;
            ActivityValue = activity.Value + "";
            ActivityInfo = activity.Name + activity.Value + "";
        }
    }
}

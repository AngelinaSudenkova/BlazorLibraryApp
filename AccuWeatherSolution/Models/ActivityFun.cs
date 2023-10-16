using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccuWeatherSolution.Models
{

    public class ActivityFun
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public bool Ascending { get; set; }
        public DateTime LocalDateTime { get; set; }
        public int EpochDateTime { get; set; }
        public float Value { get; set; }
        public string Category { get; set; }
        public int CategoryValue { get; set; }
        public string MobileLink { get; set; }
        public string Link { get; set; }
    }

}

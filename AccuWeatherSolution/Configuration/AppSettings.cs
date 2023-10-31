using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccuWeatherSolution.Configuration
{
    internal class AppSettings
    {
        public string DefaultLanguage { get; set; }

        public string BaseAPIUrl { get; set; }

        public BaseLibraryEndpoint BaseLibraryEndpoint { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccuWeatherSolution.Configuration
{
    public class BaseLibraryEndpoint
    {
        public string Base_url { get; set; }
        public string GetAllBooksEndpoint {  get; set; }

        public string DeleteEndpoint { get; set; }
        public string GetBookEndpoint { get; set; } 

        public string UpdateBookEndpoint { get; set; }
        public string CreateBookEndpoint { get; set; }

    }
}

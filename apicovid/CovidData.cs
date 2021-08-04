using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCovid
{
    public class Data
    {
        [JsonProperty("Countries")]
        public IEnumerable<CountryType> Countries { get; set; }
    }

    public class CountryType
    {
        [JsonProperty("Id")]
        public string Id { get; set; }
        
        [JsonProperty("Country")]
        public string Country { get; set; }
        
        [JsonProperty("TotalConfirmed")]
        public int TotalConfirmed { get; set; }

        [JsonProperty("TotalRecovered")]
        public int TotalRecovered { get; set; }

        public double TotalActive { get => TotalConfirmed - TotalRecovered; }
    }


}

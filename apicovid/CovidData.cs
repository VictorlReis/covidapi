using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCovid
{
    public class CovidData
    {
        [JsonProperty("Id")]
        public string Id { get; set; }
        [JsonProperty("Country")]
        public string Country { get; set; }
        [JsonProperty("CountryCode")]
        public string CountryCode { get; set; }
        [JsonProperty("Slug")]
        public string Slug { get; set; }
        [JsonProperty("NewConfirmed")]
        public int NewConfirmed { get; set; }
        [JsonProperty("TotalConfirmed")]
        public int TotalConfirmed { get; set; }
        [JsonProperty("TotalDeaths")]
        public int TotalDeaths { get; set; }
    }
}

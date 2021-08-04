using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiCovid.Services
{
    public class CovidCasesService : ICovidCasesService
    {
        //private readonly HttpClient _httpClient;

        //public CovidCasesService(HttpClient httpClient)
        //{
        //    _httpClient = httpClient;
        //}


        public IEnumerable<object> GetCountries()
        {
            try
            {
                using HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://api.covid19api.com");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.GetAsync("/summary").Result;

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = response.Content.ReadAsStringAsync().Result;

                    var p = JObject.Parse(jsonString);

                    return p.Root["Countries"];

                }
            }
            catch (Exception ex)
            {
                //log
                Console.WriteLine(ex);
            }

            return new List<object>();
        }        

    }
}

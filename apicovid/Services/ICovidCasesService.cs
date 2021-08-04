using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCovid.Services
{
    public interface ICovidCasesService
    {
        IEnumerable<CountryType> GetCountries();
    }
}

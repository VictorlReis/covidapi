using ApiCovid.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCovid.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CovidCasesController : ControllerBase
    {
        private readonly ICovidCasesService _service;

        public CovidCasesController(ICovidCasesService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<object> GetAll()
        {
            return _service.GetCountries();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace F1ResultsAssistant.Controllers
{
    [Route("api/test")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public async Task<string> Get()
        {
            var cs = (await new ErgastApi.EgrastApiRetriever().GetCurrentConstructorStandings());
            return cs[0].PositionText;
        }
    }
}

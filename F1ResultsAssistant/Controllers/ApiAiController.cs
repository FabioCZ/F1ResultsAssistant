using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using F1ResultsAssistant.Model;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace F1ResultsAssistant.Controllers
{
    [Route("f1/apiai")]
    public class ApiAiController : Controller
    {
        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]ApiAiQuery query)
        {
            //var query = JsonConvert.DeserializeObject<ApiAiQuery>(value);
            if(query.Result.Metadata.IntentName == "wcc-current-leader")
            {
                return new ObjectResult(new ApiAiResponse() { Speech = "Mercedes" });
            }
            return new ObjectResult(query.Lang);

        }
    }
}

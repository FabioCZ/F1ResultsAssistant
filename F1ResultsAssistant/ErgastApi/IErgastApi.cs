using F1ResultsAssistant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Refit;

namespace F1ResultsAssistant.ErgastApi
{
    interface IErgastApi
    {
        [Get("/api/f1/current/constructorStandings.json")]
        Task<ErgastResponse<StandingsTableWrapper>> GetCurrentConstructorStandings();
    }
}

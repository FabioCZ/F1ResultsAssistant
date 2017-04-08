using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F1ResultsAssistant.Model;
using Refit;

namespace F1ResultsAssistant.ErgastApi
{
    public class EgrastApiRetriever : IRetriever
    {
        IErgastApi api = RestService.For<IErgastApi>("http://ergast.com");

        public async Task<List<ConstructorStanding>> GetCurrentConstructorStandings()
        {
            var r = (await api.GetCurrentConstructorStandings());
            return r.MRData.StandingsTable.StandingsLists[0].ConstructorStandings;
        }
    }
}

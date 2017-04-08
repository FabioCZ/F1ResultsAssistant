using F1ResultsAssistant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F1ResultsAssistant
{
    public interface IRetriever
    {
        Task<List<ConstructorStanding>> GetCurrentConstructorStandings();
    }
}

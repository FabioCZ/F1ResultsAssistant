using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F1ResultsAssistant.Model
{
    public class StandingsTableWrapper : MRData
    {
        public StandingsTable StandingsTable { get; set; }
    }

    public class StandingsTable
    {
        public string Season { get; set; }
        public List<StandingsList> StandingsLists { get; set; }
    }

    public class StandingsList
    {
        public string Season { get; set; }
        public int Round { get; set; }
        public List<ConstructorStanding> ConstructorStandings { get; set; }
    }

    public class ConstructorStanding
    {
        public int Position { get; set; }
        public string PositionText { get; set; }
        public int Points { get; set; }
        public int Wins { get; set; }
        public Constructor Constructor { get; set; }
    }
}

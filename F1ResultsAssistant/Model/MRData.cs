using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F1ResultsAssistant.Model
{
    public class ErgastResponse<T>
    {
        public T MRData { get; set; }
    }

    public class MRData
    {
        public string Xmlns { get; set; }
        public string Series { get; set; }
        public string Url { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }
        public int Total { get; set; }
    }
}

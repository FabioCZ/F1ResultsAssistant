using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F1ResultsAssistant.Model
{
    public class ApiAiResponse
    {
        public string Speech { get; set; }
        public string DisplayText { get; set; }
        public object Data { get; set; }
        public List<object> ContextOut { get; set; }
        public string Source { get; set; }
        public object FollowUpEvent { get; set; }
    }
}

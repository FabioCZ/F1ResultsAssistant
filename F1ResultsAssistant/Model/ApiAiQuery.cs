using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F1ResultsAssistant.Model
{
    public class ApiAiQuery
    {
        public string Lang { get; set; }
        public Status Status { get; set; }
        public DateTime TimeStamp { get; set; }
        public string SessionId { get; set; }
        public Result Result { get; set; }
        public string Id { get; set; }
        public OriginalRequest OriginalRequest { get; set; }
    }

    public class Status
    {
        public string ErrorType { get; set; }
        public int Code { get; set; }
    }

    public class Result
    {
        public Dictionary<string, string> Parameters { get; set; }
        public List<string> Contexts { get; set; }
        public string ResolvedQuery { get; set; }
        public string Source { get; set; }
        public double Score { get; set; }
        public string Speech { get; set; }
        public Fulfillment FulFillment { get; set; }
        public bool ActionIncomplete { get; set; }
        public string Action { get; set; }
        public Metadata Metadata { get; set; }
    }

    public class Fulfillment
    {
        public List<Message> Messages { get; set; }
        public string Speech { get; set; }
    }

    public class Message
    {
        public string Speech { get; set; }
        public int Type { get; set; }
    }

    public class Metadata
    {
        public string IntentId { get; set; }
        public bool WebhookForSlotFillingUsed { get; set; }
        public string IntentName { get; set; }
        public bool WebhookUsed { get; set; }
    }

    public class OriginalRequest
    {
        public string Source { get; set; }

    }

    public class OriginalRequestData
    {
        public List<Input> Inputs { get; set; }
        public User User { get; set; }
        public Conversation Conversation { get; set; }
    }

    public class Input
    {
        public List<RawInput> RawInputs { get; set; }
        public string Intent { get; set; }
        public List<InputArgument> Arguments { get; set; }
    }

    public class RawInput
    {
        public string Query { get; set; }
        public int InputType { get; set; }
    }

    public class InputArgument
    {
        public string TextValue { get; set; }
        public string RawText { get; set; }
        public string Name { get; set; }
    }

    public class User
    {
        public string UserId { get; set; }
    }

    public class Conversation
    {
        public string ConversationId { get; set; }
        public int Type { get; set; }
        public string ConversationToken { get; set; }
    }
}

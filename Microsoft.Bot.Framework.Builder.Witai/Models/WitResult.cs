using Newtonsoft.Json;
using System.Collections.Generic;

namespace Microsoft.Bot.Framework.Builder.Witai.Models
{
    public class WitResult
    {
        [JsonProperty(PropertyName = "_text")]
        public string Text { get; set; }
        public string Action { get; set; }
		[JsonProperty("msg_id")]
		public string MessageId { get; set; }
		[JsonProperty("entities")]
		public Dictionary<string, IList<WitEntity>> Entities { get; set; }
		public string Type { get; set; } = "intent";
		public string Message { get; set; }
	}
}

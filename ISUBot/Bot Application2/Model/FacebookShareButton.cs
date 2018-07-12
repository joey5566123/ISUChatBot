using Microsoft.Bot.Connector;
using Newtonsoft.Json.Linq;
using System;

namespace Bot_Application2.Answer_Message
{
    using Newtonsoft.Json;

    public class FacebookShareButton
    {
        public FacebookShareButton()
        {
            this.Type = "element_share";
        }

        [JsonProperty("type")]
        public string Type { get; set; }

        public override string ToString()
        {
            return $"type: {this.Type}";
        }

    }
}
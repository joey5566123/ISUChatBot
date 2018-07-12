namespace Bot_Application2.Answer_Message
{
    using Newtonsoft.Json;

    public class FacebookChannelData
    {
        [JsonProperty("attachment")]
        public FacebookAttachment Attachment { get; internal set; }
    }
}
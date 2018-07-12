namespace Bot_Application2.Answer_Message
{
    using Newtonsoft.Json;

    public class FacebookGenericTemplateContent
    {
        public FacebookGenericTemplateContent()
        {
            this.Title = "This is a title.";
            this.Subtitle = "This is a subtitle.";
            this.ImageUrl = "";
        }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("buttons")]
        public object[] Buttons { get; set; }
    }
}
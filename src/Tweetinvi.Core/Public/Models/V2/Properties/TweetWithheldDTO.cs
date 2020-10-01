using Newtonsoft.Json;

namespace Tweetinvi.Models.V2
{
    public class TweetWithheldDTO : WithheldDTO
    {
        [JsonProperty("copyright")] public bool Copyright { get; set; }
    }
}
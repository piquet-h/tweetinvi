using Newtonsoft.Json;

namespace Tweetinvi.Models.V2.Responses
{
    public class FilteredStreamTweetResponseDTO : TweetResponseDTO
    {
        [JsonProperty("matching_rules")] public FilteredStreamMatchingRuleDTO[] MatchingRules { get; set; }
    }
}
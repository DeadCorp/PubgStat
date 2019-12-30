using Newtonsoft.Json;

namespace PubgNet.Model
{
    public class Links
    {
        [JsonProperty]
        public string Self { get; set; }
        [JsonProperty]
        public string Schema { get; set; }
    }
}

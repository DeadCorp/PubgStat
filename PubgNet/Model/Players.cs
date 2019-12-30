using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PubgNet.Model
{
    public class PlayersRoot
    {
        [JsonProperty]
        public List<PlayerData> Data { get; set; }
        [JsonProperty]
        public Links Links { get; set; }
    }

    public class PlayerData
    {
        [JsonProperty]
        public string Type { get; set; }
        [JsonProperty]
        public string Id { get; set; }
        [JsonProperty]
        public PlayerAttributes Attributes { get; set; }
        [JsonProperty]
        public PlayerRelationships Relationships { get; set; }
    }

    public class PlayerAttributes
    {
        [JsonProperty]
        public string Name { get; set; }
        [JsonProperty]
        public string ShardId { get; set; }
        [JsonProperty]
        public object Stats { get; set; }
        [JsonProperty]
        public DateTime CreatedAt { get; set; }
        [JsonProperty]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty]
        public string PatchVersion { get; set; }
        [JsonProperty]
        public string TitleId { get; set; }
    }

    public class PlayerRelationships
    {
        [JsonProperty]
        public PlayerAssets Assets { get; set;}
        [JsonProperty]
        public PlayerMatches Matches { get; set; }
    }

    public class PlayerAssets
    {
        [JsonProperty]
        public List<object> Data { get; set; }
    }

    public class PlayerMatches
    {
        [JsonProperty]
        public List<PlayerMatchData> Data { get; set; }
    }

    public class PlayerMatchData
    {
        [JsonProperty]
        public string Type { get; set; }
        [JsonProperty]
        public string Id { get; set; }
    }
}

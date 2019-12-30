using Newtonsoft.Json;
using System.Collections.Generic;

namespace PubgNet.Model
{
    public class LeaderboardsRoot
    {
        [JsonProperty]
        public LeaderboardsData Data { get; set; }
        [JsonProperty]
        public List<LeaderboardsIncluded> Included { get; set; }
        [JsonProperty]
        public Links Links { get; set; }
    }

    public class LeaderboardsData
    {
        [JsonProperty]
        public string Type { get; set; }
        [JsonProperty]
        public string Id { get; set; }
        [JsonProperty]
        public LeaderboardsAttributes Attributes { get; set; }
        [JsonProperty]
        public LeaderboardsRelationships Relationships { get; set; }
    }

    public class LeaderboardsAttributes
    {
        [JsonProperty]
        public string ShardId { get; set; }
        [JsonProperty]
        public string GameMode { get; set; }
    }

    public class LeaderboardsRelationships
    {
        [JsonProperty]
        public LeaderboardsPlayers Players { get; set; }
    }

    public class LeaderboardsPlayers
    {
        [JsonProperty]
        public List<LeaderboardsPlayersData> Data { get; set; }
    }

    public class LeaderboardsPlayersData
    {
        [JsonProperty]
        public string Type { get; set; }
        [JsonProperty]
        public string Id { get; set; }
    }

    public class LeaderboardsIncluded
    {
        [JsonProperty]
        public string Type { get; set; }
        [JsonProperty]
        public string Id { get; set; }
        [JsonProperty]
        public LeaderboardsIncludedAttributes Attributes { get; set; }
    }

    public class LeaderboardsIncludedAttributes
    {
        [JsonProperty]
        public string Name { get; set; }
        [JsonProperty]
        public int Rank { get; set; }
        [JsonProperty]
        public LeaderboardStats Stats { get; set; }
    }

    public class LeaderboardStats
    {
        [JsonProperty]
        public int RankPoints { get; set; }
        [JsonProperty]
        public int Wins { get; set; }
        [JsonProperty]
        public int Games { get; set; }
        [JsonProperty]
        public double WinRatio { get; set; }
        [JsonProperty]
        public int AverageDamage { get; set; }
        [JsonProperty]
        public int Kills { get; set; }
        [JsonProperty]
        public double KillDeathRatio { get; set; }
        [JsonProperty]
        public double AverageRank { get; set; }
    }
}

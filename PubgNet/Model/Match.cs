using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PubgNet.Model
{
    public class MatchRoot
    {
        [JsonProperty]
        public MatchData Data { get; set; }
        [JsonProperty]
        public List<MatchIncluded> Included { get; set; }
        [JsonProperty]
        public Links Links { get; set; }
    }

    public class MatchData
    {
        [JsonProperty]
        public string Type { get; set; }
        [JsonProperty]
        public string Id { get; set; }
        [JsonProperty]
        public MatchAttributes Attributes { get; set; }
        [JsonProperty]
        public MatchRelationships Relationships { get; set; }
        [JsonProperty]
        public Links Links { get; set; }
    }

    public class MatchAttributes
    {
        [JsonProperty]
        public string GameMode { get; set; }
        [JsonProperty]
        public bool IsCustomMatch { get; set; }
        [JsonProperty]
        public DateTime CreatedAt { get; set; }
        [JsonProperty]
        public int Duration { get; set; }
        [JsonProperty]
        public object Stats { get; set; }
        [JsonProperty]
        public string TitleId { get; set; }
        [JsonProperty]
        public string ShardId { get; set; }
        [JsonProperty]
        public object Tags { get; set; }
        [JsonProperty]
        public string MapName { get; set; }
        [JsonProperty]
        public string SeasonState { get; set; }
    }

    public class MatchRelationships
    {
        [JsonProperty]
        public MatchRosters Rosters { get; set; }
        [JsonProperty]
        public MatchRosterAssets Assets { get; set; }
    }

    public class MatchRosters
    {
        [JsonProperty]
        public List<MatchRosterData> Data { get; set; }
    }

    public class MatchRosterData
    {
        [JsonProperty]
        public string Type { get; set; }
        [JsonProperty]
        public string Id { get; set; }
    }

    public class MatchRosterAssets
    {
        [JsonProperty]
        public List<MatchRosterAssetsData> Data { get; set; }
    }

    public class MatchRosterAssetsData
    {
        [JsonProperty]
        public string Type { get; set; }
        [JsonProperty]
        public string Id { get; set; }
    }

    public class MatchIncluded
    {
        [JsonProperty]
        public string Type { get; set; }
        [JsonProperty]
        public string Id { get; set; }
        [JsonProperty]
        public MatchIncludedAttributes Attributes { get; set; }
        [JsonProperty]
        public MatchIncludedRelationships Relationships { get; set; }
    }

    public class MatchIncludedAttributes
    {
        [JsonProperty]
        public MatchStats Stats { get; set; }
        [JsonProperty]
        public string Actor { get; set; }
        [JsonProperty]
        public string ShardId { get; set; }
        [JsonProperty]
        public string Won { get; set; }
        [JsonProperty]
        public string Name { get; set; }
        [JsonProperty]
        public string Description { get; set; }
        [JsonProperty]
        public DateTime? CreatedAt { get; set; }
        [JsonProperty]
        public string URL { get; set; }
    }

    public class MatchStats
    {
        [JsonProperty]
        public int DBNOs { get; set; }
        [JsonProperty]
        public int Assists { get; set; }
        [JsonProperty]
        public int Boosts { get; set; }
        [JsonProperty]
        public double DamageDealt { get; set; }
        [JsonProperty]
        public string DeathType { get; set; }
        [JsonProperty]
        public int HeadshotKills { get; set; }
        [JsonProperty]
        public int Heals { get; set; }
        [JsonProperty]
        public int KillPlace { get; set; }
        [JsonProperty]
        public int KillPoints { get; set; }
        [JsonProperty]
        public int KillPointsDelta { get; set; }
        [JsonProperty]
        public int KillStreaks { get; set; }
        [JsonProperty]
        public int Kills { get; set; }
        [JsonProperty]
        public int LastKillPoints { get; set; }
        [JsonProperty]
        public int LastWinPoints { get; set; }
        [JsonProperty]
        public double LongestKill { get; set; }
        [JsonProperty]
        public int MostDamage { get; set; }
        [JsonProperty]
        public string Name { get; set; }
        [JsonProperty]
        public string PlayerId { get; set; }
        [JsonProperty]
        public int RankPoints { get; set; }
        [JsonProperty]
        public int Revives { get; set; }
        [JsonProperty]
        public double RideDistance { get; set; }
        [JsonProperty]
        public int RoadKills { get; set; }
        [JsonProperty]
        public double SwimDistance { get; set; }
        [JsonProperty]
        public int TeamKills { get; set; }
        [JsonProperty]
        public double TimeSurvived { get; set; }
        [JsonProperty]
        public int VehicleDestroys { get; set; }
        [JsonProperty]
        public double WalkDistance { get; set; }
        [JsonProperty]
        public int WeaponsAcquired { get; set; }
        [JsonProperty]
        public int WinPlace { get; set; }
        [JsonProperty]
        public int WinPoints { get; set; }
        [JsonProperty]
        public int WinPointsDelta { get; set; }
        [JsonProperty]
        public int? Rank { get; set; }
        [JsonProperty]
        public int? TeamId { get; set; }
    }

    public class MatchIncludedRelationships
    {
        [JsonProperty]
        public MatchIncludedTeam Team { get; set; }
        [JsonProperty]
        public MatchIncludedParticipants Participants { get; set; }
    }

    public class MatchIncludedTeam
    {
        [JsonProperty]
        public object Data { get; set; } 
    }

    public class MatchIncludedParticipants
    {
        [JsonProperty]
        public List<MatchIncludedParticipantsData> Data { get; set; }
    }

    public class MatchIncludedParticipantsData
    {
        [JsonProperty]
        public string Type { get; set; }
        [JsonProperty]
        public string Id { get; set; }
    }
}

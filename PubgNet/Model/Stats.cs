using Newtonsoft.Json;
using System.Collections.Generic;

namespace PubgNet.Model
{
    public class StatsRoot
    {
        [JsonProperty]
        public StatsData Data { get; set; }
        [JsonProperty]
        public Links Links { get; set; }
    }

    public class StatsData
    {
        [JsonProperty]
        public string Type { get; set; }
        [JsonProperty]
        public StatsAttributes Attributes { get; set; }
        [JsonProperty]
        public StatsRelationships Relationships { get; set; }
    }

    public class StatsAttributes
    {
        [JsonProperty]
    public GameModeStats GameModeStats { get; set; }
    }

    public class GameModeStats
{
        [JsonProperty("solo")]
        public GameModeStatsData Solo { get; set; }
        [JsonProperty("solo-fpp")]
        public GameModeStatsData SoloFpp { get; set; }
        [JsonProperty("duo")]
        public GameModeStatsData Duo { get; set; }
        [JsonProperty("duo-fpp")]
        public GameModeStatsData DuoFpp { get; set; }
        [JsonProperty("squad")]
        public GameModeStatsData Squad { get; set; }
        [JsonProperty("squad-fpp")]
        public GameModeStatsData SquadFpp { get; set; }
    }

    public class GameModeStatsData
    {
        [JsonProperty]
        public int Assists { get; set; }
        [JsonProperty]
        public double BestRankPoint { get; set; }
        [JsonProperty]
        public int Boosts { get; set; }
        [JsonProperty]
        public int DBNOs { get; set; }
        [JsonProperty]
        public int DailyKills { get; set; }
        [JsonProperty]
        public int DailyWins { get; set; }
        [JsonProperty]
        public double DamageDealt { get; set; }
        [JsonProperty]
        public int Days { get; set; }
        [JsonProperty]
        public int HeadshotKills { get; set; }
        [JsonProperty]
        public int Heals { get; set; }
        [JsonProperty]
        public int KillPoints { get; set; }
        [JsonProperty]
        public int Kills { get; set; }
        [JsonProperty]
        public double LongestKill { get; set; }
        [JsonProperty]
        public double LongestTimeSurvived { get; set; }
        [JsonProperty]
        public int Losses { get; set; }
        [JsonProperty]
        public int MaxKillStreaks { get; set; }
        [JsonProperty]
        public double MostSurvivalTime { get; set; }
        [JsonProperty]
        public double RankPoints { get; set; }
        [JsonProperty]
        public string RankPointsTitle { get; set; }
        [JsonProperty]
        public int Revives { get; set; }
        [JsonProperty]
        public double RideDistance { get; set; }
        [JsonProperty]
        public int RoadKills { get; set; }
        [JsonProperty]
        public int RoundMostKills { get; set; }
        [JsonProperty]
        public int RoundsPlayed { get; set; }
        [JsonProperty]
        public int Suicides { get; set; }
        [JsonProperty]
        public double SwimDistance { get; set; }
        [JsonProperty]
        public int TeamKills { get; set; }
        [JsonProperty]
        public double TimeSurvived { get; set; }
        [JsonProperty]
        public int Top10s { get; set; }
        [JsonProperty]
        public int VehicleDestroys { get; set; }
        [JsonProperty]
        public double WalkDistance { get; set; }
        [JsonProperty]
        public int WeaponsAcquired { get; set; }
        [JsonProperty]
        public int WeeklyKills { get; set; }
        [JsonProperty]
        public int WeeklyWins { get; set; }
        [JsonProperty]
        public int WinPoints { get; set; }
        [JsonProperty]
        public int Wins { get; set; }
    }

    public class StatsRelationships
    {
        [JsonProperty]
        public StatsPlayer Player { get; set; }
        [JsonProperty]
        public StatsSeason Season { get; set; }
        [JsonProperty]
        public StatsMatches MatchesSolo { get; set; }
        [JsonProperty]
        public StatsMatches MatchesSoloFpp { get; set; }
        [JsonProperty]
        public StatsMatches MatchesDuo { get; set; }
        [JsonProperty]
        public StatsMatches MatchesDuoFpp { get; set; }
        [JsonProperty]
        public StatsMatches MatchesSquad { get; set; }
        [JsonProperty]
        public StatsMatches MatchesSquadFpp { get; set; }
    }

    public class StatsPlayer
    {
        [JsonProperty]
        public StatsPlayerData Data { get; set; }
    }

    public class StatsPlayerData
    {
        [JsonProperty]
        public string Type { get; set; }
        [JsonProperty]
        public string Id { get; set; }
    }

    public class StatsSeason
    {
        [JsonProperty]
        public StatsSeasonData Data { get; set; }
    }

    public class StatsSeasonData
    {
        [JsonProperty]
        public string Type { get; set; }
        [JsonProperty]
        public string Id { get; set; }
}

    public class StatsMatches
    {
        [JsonProperty]
        public List<StatsMatchData> Data { get; set; }
    }

    public class StatsMatchData
    {
        [JsonProperty]
        public string Type { get; set; }
        [JsonProperty]
        public string Id { get; set; }
    }
}

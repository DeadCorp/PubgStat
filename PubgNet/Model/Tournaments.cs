using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PubgNet.Model
{
    public class TournamentsRoot
    {
        [JsonProperty]
        public List<TournamentData> Data { get; set; }
        [JsonProperty]
        public Links Links { get; set; }
    }

    public class TournamentRoot
    {
        [JsonProperty]
        public TournamentData Data { get; set; }
        [JsonProperty]
        public List<TournamentIncluded> Included { get; set; }
        [JsonProperty]
        public Links Links { get; set; }
    }

    public class TournamentData
    {
        [JsonProperty]
        public string Type { get; set; }
        [JsonProperty]
        public string Id { get; set; }
        [JsonProperty]
        public TournamentAttributes Attributes { get; set; }
        [JsonProperty]
        public TournamentRelationships Relationships { get; set; }
    }

    public class TournamentAttributes
    {
        [JsonProperty]
        public DateTime CreatedAt { get; set; }
    }

    public class TournamentIncluded
    {
        [JsonProperty]
        public string Type { get; set; }
        [JsonProperty]
        public string Id { get; set; }
        [JsonProperty]
        public TournamentAttributes Attributes { get; set; }
    }

    public class TournamentRelationships
    {
        [JsonProperty]
        public TournamentMatches Matches { get; set; }
    }

    public class TournamentMatches
    {
        [JsonProperty]
        public List<TournamentMatchesData> Data { get; set; }
    }

    public class TournamentMatchesData
    {
        [JsonProperty]
        public string Type { get; set; }
        [JsonProperty]
        public string Id { get; set; }
    }
}

#define DEBUG_CLIENT // Use this to print http requests and responses to console

using Newtonsoft.Json;
using PubgNet.Http;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PubgNet
{
    

    // Entry point for PubgNet client.
    // Creates a http client using your api key.
    public class PubgNetClient
    {
        // Private variables.
        private readonly HttpHandler _HttpHandler;
        private readonly string _Platform;
        public readonly string ApiKey = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJqdGkiOiI0ZjYyODUxMC1kM2UwLTAxMzctZDdhNC0wZjNhMTg5NGE0ZTciLCJpc3MiOiJnYW1lbG9ja2VyIiwiaWF0IjoxNTcxNDA4NDA3LCJwdWIiOiJibHVlaG9sZSIsInRpdGxlIjoicHViZyIsImFwcCI6ImNpcGlkcmlzLWdtYWlsIn0.vTbdRV5CgGMOUUU7zDmMojlSULLafjhfFbBfEkbidjI";
        
    
    // Checks if the api key exists, then constructs a http handler to manage requests.
    public PubgNetClient(string api_key, string platform = "steam") // By default, steam
        {
            if (string.IsNullOrEmpty(api_key)) throw new ArgumentException("Client: Api Key cannot be empty.");
            _HttpHandler = new HttpHandler("https://api.pubg.com/", api_key, "application/vnd.api+json");
            _Platform = platform;
        }

        // Gets a list of players by username(s).
        // Usernames are case sensitive.
        // According to the api, this can only get data for up to 6 players.
        public async Task<PubgNet.Model.PlayersRoot> GetPlayersByUsernames(string[] playerNames)
        {
#if DEBUG_CLIENT
            if (playerNames.Length >= 6)
            {
                string valid_playerNames = string.Join(",", playerNames.Take(6).ToArray());
               // Console.WriteLine($"Client: (Warning) This will only return data for {valid_playerNames}");
            }
#endif
            string input_playerNames = string.Join(",", playerNames);
            string request = $"shards/{_Platform}/players?filter[playerNames]={input_playerNames}";
            string response = await _HttpHandler.RequestAsync(request).ConfigureAwait(false);
            var json_object = JsonConvert.DeserializeObject<PubgNet.Model.PlayersRoot>(response);
            return json_object;
        }

        // Gets a list of players by id(s).
        // According to the api, this can only get data for up to 6 players.
        public async Task<PubgNet.Model.PlayersRoot> GetPlayersByIds(string[] playerIds)
        {
#if DEBUG_CLIENT
            if (playerIds.Length >= 6)
            {
                string valid_playerIds = string.Join(",", playerIds.Take(6).ToArray());
                //Console.WriteLine($"Client: (Warning) This will only return data for {valid_playerIds}");
            }
#endif
            string input_playerIds = string.Join(",", playerIds);
            string request = $"shards/{_Platform}/players?filter[playerIds]={input_playerIds}";
            string response = await _HttpHandler.RequestAsync(request).ConfigureAwait(false);
            var json_object = JsonConvert.DeserializeObject<PubgNet.Model.PlayersRoot>(response);
            return json_object;
        }

        // Gets a list of all seasons.
        public async Task<PubgNet.Model.SeasonsRoot> GetSeasons()
        {
            string request = $"shards/{_Platform}/seasons";
            string response = await _HttpHandler.RequestAsync(request).ConfigureAwait(false);
            var json_object = JsonConvert.DeserializeObject<PubgNet.Model.SeasonsRoot>(response);
            return json_object;
        }

        // Get seasons stats for a specific player and season.
        public async Task<PubgNet.Model.StatsRoot> GetSeasonStatsForPlayer(string accountId, string seasonId)
        {
            string request = $"shards/{_Platform}/players/{accountId}/seasons/{seasonId}";
            string response = await _HttpHandler.RequestAsync(request).ConfigureAwait(false);
            var json_object = JsonConvert.DeserializeObject<PubgNet.Model.StatsRoot>(response);
            return json_object;
        }

        // Get lifetime stats for a specific player and season.
        public async Task<PubgNet.Model.StatsRoot> GetLifetimeStatsForPlayer(string accountId)
        {
            string request = $"shards/{_Platform}/players/{accountId}/seasons/lifetime";
            string response = await _HttpHandler.RequestAsync(request).ConfigureAwait(false);
            var json_object = JsonConvert.DeserializeObject<PubgNet.Model.StatsRoot>(response);
            return json_object;
        }

        // Get a single match's data.
        public async Task<PubgNet.Model.MatchRoot> GetMatch(string id)
        {
            string request = $"shards/{_Platform}/matches/{id}";
            string response = await _HttpHandler.RequestAsync(request).ConfigureAwait(false);
            var json_object = JsonConvert.DeserializeObject<PubgNet.Model.MatchRoot>(response);
            return json_object;
        }

        // Get leaderboard data for game mode.
        public async Task<PubgNet.Model.LeaderboardsRoot> GetLeaderboards(string gameMode, int num = 0)
        {
            string request = $"shards/{_Platform}/leaderboards/{gameMode}?page[number]={num}";
            string response = await _HttpHandler.RequestAsync(request).ConfigureAwait(false);
            var json_object = JsonConvert.DeserializeObject<PubgNet.Model.LeaderboardsRoot>(response);
            return json_object;
        }

        // Get a list of all tournaments
        public async Task<PubgNet.Model.TournamentsRoot> GetTournaments()
        {
            string request = $"tournaments";
            string response = await _HttpHandler.RequestAsync(request).ConfigureAwait(false);
            var json_object = JsonConvert.DeserializeObject<PubgNet.Model.TournamentsRoot>(response);
            return json_object;
        }

        // Get a single tournament's data
        public async Task<PubgNet.Model.TournamentRoot> GetTournament(string id)
        {
            string request = $"tournaments/{id}";
            string response = await _HttpHandler.RequestAsync(request).ConfigureAwait(false);
            var json_object = JsonConvert.DeserializeObject<PubgNet.Model.TournamentRoot>(response);
            return json_object;
        }
    }
}

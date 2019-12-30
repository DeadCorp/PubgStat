using System.Threading.Tasks;
using System;
namespace PubgNet.Example
{
    class Program
    {
        static void Main()
        {
            MainAsync().Wait();
            async Task MainAsync()
            {
                string maxkill = null;
                /*string id_name = null;
                string id_match = null;
                PubgNetClient client = new PubgNetClient("eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJqdGkiOiI0ZjYyODUxMC1kM2UwLTAxMzctZDdhNC0wZjNhMTg5NGE0ZTciLCJpc3MiOiJnYW1lbG9ja2VyIiwiaWF0IjoxNTcxNDA4NDA3LCJwdWIiOiJibHVlaG9sZSIsInRpdGxlIjoicHViZyIsImFwcCI6ImNpcGlkcmlzLWdtYWlsIn0.vTbdRV5CgGMOUUU7zDmMojlSULLafjhfFbBfEkbidjI");
                var players = await client.GetPlayersByUsernames(new string[]{"DeadCorporation"});


                var season2 = await client.GetSeasons();
                 foreach(var s in players.Data)
                  {
                      id_name = s.Id;
                  }
                foreach (var i in season2.Data)
                {

                    if (i.Attributes.IsCurrentSeason)
                    {
                         id_match = i.Id;
                    }
                    var season = await client.GetSeasonStatsForPlayer(id_name,id_match);
                }

                */
                string id_name = null;
                PubgNetClient client = new PubgNetClient("eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJqdGkiOiI0ZjYyODUxMC1kM2UwLTAxMzctZDdhNC0wZjNhMTg5NGE0ZTciLCJpc3MiOiJnYW1lbG9ja2VyIiwiaWF0IjoxNTcxNDA4NDA3LCJwdWIiOiJibHVlaG9sZSIsInRpdGxlIjoicHViZyIsImFwcCI6ImNpcGlkcmlzLWdtYWlsIn0.vTbdRV5CgGMOUUU7zDmMojlSULLafjhfFbBfEkbidjI");
                var players = await client.GetPlayersByUsernames(new string[] { "DeadCorporation" });
                foreach (var s in players.Data)
                {
                    id_name = s.Id;
                    maxkill = id_name;
                    break;
                }
                Console.WriteLine(maxkill);
                System.Console.ReadKey();

            }
        }
    }
}


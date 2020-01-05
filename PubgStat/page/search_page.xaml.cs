using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PubgNet;
using PubgStat.view_model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PubgNet.Model;
using System.IO;
using System.Reflection;

namespace PubgStat.page {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class search_page : ContentPage {
        PubgNetClient client = new PubgNetClient(GetApi());
        
        static string Name;
        private string player_id;
        private string season_ids;
        public static data_page_view_model solo_fpp_vm =  new data_page_view_model();
        public static data_page_view_model solo_tpp_vm =  new data_page_view_model();
        public static data_page_view_model duo_fpp_vm =  new data_page_view_model();
        public static data_page_view_model duo_tpp_vm =  new data_page_view_model();
        public static data_page_view_model squad_fpp_vm =  new data_page_view_model();
        public static data_page_view_model squad_tpp_vm =  new data_page_view_model();

       


        public search_page() {
            InitializeComponent();
            entry_player_name.Text = "DeadCorporation";

            

            Dictionary<string,string> list =  new Dictionary<string, string>{
                {"Season 1" , "division.bro.official.pc-2018-01" },
                {"Season 2" , "division.bro.official.pc-2018-02" },
                {"Season 3" , "division.bro.official.pc-2018-03" },
                {"Season 4" , "division.bro.official.pc-2018-04" },
                {"Season 5" , "division.bro.official.pc-2018-05" },

            };

            foreach(var item in list) {
                    picker.Items.Add(item.Key);

               
            }

            season_ids = list["Season 5"];
            picker.SelectedIndexChanged += (sender,args) =>
            {
                if(picker.SelectedIndex == -1) {
                    season_ids = list["Season 5"];
                }
                else {
                    season_ids =  list[picker.Items[picker.SelectedIndex]];
                    picker.Title = picker.Items[picker.SelectedIndex];
                }
            };

          

        }

       

        private async  void search_button_Clicked(object sender,EventArgs e) {
            Name = entry_player_name.Text ;
           
            await take_data();

            await Shell.Current.GoToAsync("//season_solo");



        }

        public static string GetApi() {
            return "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJqdGkiOiI0ZjYyODUxMC1kM2UwLTAxMzctZDdhNC0wZjNhMTg5NGE0ZTciLCJpc3MiOiJnYW1lbG9ja2VyIiwiaWF0IjoxNTcxNDA4NDA3LCJwdWIiOiJibHVlaG9sZSIsInRpdGxlIjoicHViZyIsImFwcCI6ImNpcGlkcmlzLWdtYWlsIn0.vTbdRV5CgGMOUUU7zDmMojlSULLafjhfFbBfEkbidjI";
        }
        public async Task take_data() {
            
            var players = await client.GetPlayersByUsernames(new string[] { Name });
            if(Name == null)
                await DisplayAlert("Уведомление","Поле не може бути пустим","ОK");
            else if(players == null)
                await DisplayAlert("Уведомление","Неправильне імя гравця","ОK");
            else {

                foreach(var item in players.Data) {
                    player_id = item.Id;
                }


                var season_stat = await client.GetSeasonStatsForPlayer(player_id,season_ids);

                

                solo_fpp_vm = set_vm(season_stat.Data.Attributes.GameModeStats.SoloFpp,solo_fpp_vm);
                duo_fpp_vm =  set_vm(season_stat.Data.Attributes.GameModeStats.DuoFpp,duo_fpp_vm);
                squad_fpp_vm = set_vm(season_stat.Data.Attributes.GameModeStats.SquadFpp,squad_fpp_vm);

                solo_tpp_vm =  set_vm(season_stat.Data.Attributes.GameModeStats.Solo,solo_tpp_vm);
                duo_tpp_vm =  set_vm(season_stat.Data.Attributes.GameModeStats.Duo,solo_tpp_vm);
                squad_tpp_vm =  set_vm(season_stat.Data.Attributes.GameModeStats.Squad,solo_tpp_vm);
            } 
        }
        
       
    
        private data_page_view_model set_vm(GameModeStatsData vid,data_page_view_model vm) {
           
            vm.assists = vid.Assists;
            vm.boosts = vid.Boosts;
            vm.headshots = vid.HeadshotKills;
            vm.heals = vid.Heals;
            vm.kills = vid.Kills;
            vm.knocks = vid.DBNOs;
            vm.k_d = Math.Round((double)vid.Kills / (double)vid.Losses,2);
            vm.longest_kill = Math.Round(vid.LongestKill);
            vm.max_kill_streak = vid.MaxKillStreaks;
            vm.most_survival_time = Math.Round(vid.MostSurvivalTime / 60,2);
            vm.rank_points = Math.Round(vid.RankPoints);
            vm.ride_dist = Math.Round(vid.RideDistance / 100,2);
            vm.road_kill = vid.RoadKills;
            vm.round_max_kill = vid.RoundMostKills;
            vm.round_played = vid.RoundsPlayed;
            vm.suicide = vid.Suicides;
            vm.swim_dist = Math.Round(vid.SwimDistance / 1000,2);
            vm.team_kill = vid.TeamKills;
            vm.top_10 = vid.Top10s;
            vm.total_survival_time = Math.Round(vid.TimeSurvived / 60,2);
            vm.vehicle_destroys = vid.VehicleDestroys;
            vm.walk_dist = Math.Round(vid.WalkDistance / 1000,2);
            vm.wins = vid.Wins;
            vm.weaponsAcquired = vid.WeaponsAcquired;
            vm.avg_damage = Math.Round(vid.DamageDealt / (double)vid.RoundsPlayed);
            vm.revives = vid.Revives;

            return vm;



        }

    }
}
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
using System.Linq;
using System.Timers;

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

        public static data_page_view_model lsolo_fpp_vm =  new data_page_view_model();
        public static data_page_view_model lsolo_tpp_vm =  new data_page_view_model();
        public static data_page_view_model lduo_fpp_vm =  new data_page_view_model();
        public static data_page_view_model lduo_tpp_vm =  new data_page_view_model();
        public static data_page_view_model lsquad_fpp_vm =  new data_page_view_model();
        public static data_page_view_model lsquad_tpp_vm =  new data_page_view_model();

        private Image solo_i = new Image();
        private Image solo_i_t = new Image();
        private Image duo_i = new Image();
        private Image duo_i_t = new Image();
        private Image sq_i = new Image();
        private Image sq_i_t = new Image();
       

        private bool check_reaspon = true;

        private int click_count = 0;
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
            Timer timer = new Timer();
            if(click_count < 3) {
                click_count++;
                timer = new Timer(60000);
                timer.Elapsed += Timer_Elapsed;
                Name = entry_player_name.Text;
                await take_data();
                if(check_reaspon)
                    await Shell.Current.GoToAsync("//season_solo");
                

            }
            else {
                
                await DisplayAlert("Уведомление","Перевищення кількості запитів.\nНе робіть більше 3 запитів у хвилину.\nЗачекайте","Чекаю");
            }
            

        }

        private void Timer_Elapsed(object sender,ElapsedEventArgs e) {
            click_count = 0;
        }



        public static string GetApi() {
            return "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJqdGkiOiI0ZjYyODUxMC1kM2UwLTAxMzctZDdhNC0wZjNhMTg5NGE0ZTciLCJpc3MiOiJnYW1lbG9ja2VyIiwiaWF0IjoxNTcxNDA4NDA3LCJwdWIiOiJibHVlaG9sZSIsInRpdGxlIjoicHViZyIsImFwcCI6ImNpcGlkcmlzLWdtYWlsIn0.vTbdRV5CgGMOUUU7zDmMojlSULLafjhfFbBfEkbidjI";
        }
        public async Task take_data() {
            
            var players = await client.GetPlayersByUsernames(new string[] { Name });

            if(Name == null) {
                await DisplayAlert("Уведомление","Поле не може бути пустим","ОK");
                check_reaspon = false;
            }
            else if(players == null) {
                await DisplayAlert("Уведомление","Неправильне імя гравця","ОK");
                check_reaspon = false;
            }
            else {

                foreach(var item in players.Data) {
                    player_id = item.Id;
                }


                var season_stat = await client.GetSeasonStatsForPlayer(player_id,season_ids);
                var lifetime_stat = await client.GetLifetimeStatsForPlayer(player_id);



                solo_fpp_vm = set_vm(season_stat.Data.Attributes.GameModeStats.SoloFpp,solo_fpp_vm);
                solo_fpp_vm.image = get_rank_pics(solo_fpp_vm.rank_points,solo_i);
                MessagingCenter.Send<search_page,data_page_view_model>(this,"data_s",solo_fpp_vm);

                duo_fpp_vm = set_vm(season_stat.Data.Attributes.GameModeStats.DuoFpp,duo_fpp_vm);
                duo_fpp_vm.image = get_rank_pics(duo_fpp_vm.rank_points,duo_i);
                MessagingCenter.Send<search_page,data_page_view_model>(this,"data_d",duo_fpp_vm);

                squad_fpp_vm = set_vm(season_stat.Data.Attributes.GameModeStats.SquadFpp,squad_fpp_vm);
                squad_fpp_vm.image = get_rank_pics(squad_fpp_vm.rank_points,sq_i);
                MessagingCenter.Send<search_page,data_page_view_model>(this,"data_sq",squad_fpp_vm);

                solo_tpp_vm = set_vm(season_stat.Data.Attributes.GameModeStats.Solo,solo_tpp_vm);
                solo_tpp_vm.image = get_rank_pics(solo_tpp_vm.rank_points,solo_i_t);
                MessagingCenter.Send<search_page,data_page_view_model>(this,"data_s_t",solo_tpp_vm);

                duo_tpp_vm = set_vm(season_stat.Data.Attributes.GameModeStats.Duo,duo_tpp_vm);
                duo_tpp_vm.image = get_rank_pics(duo_tpp_vm.rank_points,duo_i_t);
                MessagingCenter.Send<search_page,data_page_view_model>(this,"data_d_t",duo_tpp_vm);

                squad_tpp_vm = set_vm(season_stat.Data.Attributes.GameModeStats.Squad,squad_tpp_vm);
                squad_tpp_vm.image = get_rank_pics(squad_tpp_vm.rank_points,sq_i_t);
                MessagingCenter.Send<search_page,data_page_view_model>(this,"data_sq_t",squad_tpp_vm);





                lsolo_fpp_vm = set_vm(lifetime_stat.Data.Attributes.GameModeStats.SoloFpp,lsolo_fpp_vm);
                MessagingCenter.Send<search_page,data_page_view_model>(this,"data_ls",lsolo_fpp_vm);

                lduo_fpp_vm = set_vm(lifetime_stat.Data.Attributes.GameModeStats.DuoFpp,lduo_fpp_vm);
                MessagingCenter.Send<search_page,data_page_view_model>(this,"data_ld",lduo_fpp_vm);

                lsquad_fpp_vm = set_vm(lifetime_stat.Data.Attributes.GameModeStats.SquadFpp,lsquad_fpp_vm);
                MessagingCenter.Send<search_page,data_page_view_model>(this,"data_lsq",lsquad_fpp_vm);


                lsolo_tpp_vm = set_vm(lifetime_stat.Data.Attributes.GameModeStats.Solo,lsolo_tpp_vm);
                MessagingCenter.Send<search_page,data_page_view_model>(this,"data_ls_t",lsolo_tpp_vm);

                lduo_tpp_vm = set_vm(lifetime_stat.Data.Attributes.GameModeStats.Duo,lduo_tpp_vm);
                MessagingCenter.Send<search_page,data_page_view_model>(this,"data_ld_t",lduo_tpp_vm);

                lsquad_tpp_vm = set_vm(lifetime_stat.Data.Attributes.GameModeStats.Squad,lsquad_tpp_vm);
                MessagingCenter.Send<search_page,data_page_view_model>(this,"data_lsq_t",lsquad_tpp_vm);

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
        private Image get_rank_pics(double value,Image temp) {



            //UNKNOWN
            if(value <=1 ) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Unknown.png"); } 
            //BEGINNER
            if(Enumerable.Range(1,199).Contains((int)value)) {temp.Source = ImageSource.FromResource("PubgStat.Ranks.Beginner_01.png"); }
            if(Enumerable.Range(200,399).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Beginner_02.png"); }
            if(Enumerable.Range(400,599).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Beginner_03.png"); }
            if(Enumerable.Range(600,799).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Beginner_04.png"); }
            if(Enumerable.Range(800,999).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Beginner_05.png"); }
            //NOVICE
            if(Enumerable.Range(1000,1199).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Novice_01.png"); }
            if(Enumerable.Range(1200,1399).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Novice_02.png"); }
            if(Enumerable.Range(1400,1599).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Novice_03.png"); }
            if(Enumerable.Range(1600,1799).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Novice_04.png"); }
            if(Enumerable.Range(1800,1999).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Novice_05.png"); }
            //EXPERIENCED
            if(Enumerable.Range(2000,2199).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Experienced_01.png"); }
            if(Enumerable.Range(2200,2399).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Experienced_02.png"); }
            if(Enumerable.Range(2400,2599).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Experienced_03.png"); }
            if(Enumerable.Range(2600,2799).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Experienced_04.png"); }
            if(Enumerable.Range(2800,2999).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Experienced_05.png"); }
            //SKILLED
            if(Enumerable.Range(3000,3199).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Skilled_01.png"); }
            if(Enumerable.Range(3200,3399).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Skilled_02.png"); } 
            if(Enumerable.Range(3400,3599).Contains((int)value)) {  temp.Source = ImageSource.FromResource("PubgStat.Ranks.Skilled_03.png"); }
            if(Enumerable.Range(3600,3799).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Skilled_04.png"); }
            if(Enumerable.Range(3800,3999).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Skilled_05.png"); }
            //SPECIALIST
            if(Enumerable.Range(4000,4199).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Specialist_01.png"); }
            if(Enumerable.Range(4200,4399).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Specialist_02.png"); }
            if(Enumerable.Range(4400,4599).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Specialist_03.png"); }
            if(Enumerable.Range(4600,4799).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Specialist_04.png"); }
            if(Enumerable.Range(4800,4999).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Specialist_05.png"); }
            //EXPERT
            if(Enumerable.Range(5000,5999).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Expert.png"); }
            //SURVIVOR
            if(value > 6000) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Survivor.png"); } 


            

            return temp;


        }

    }

}
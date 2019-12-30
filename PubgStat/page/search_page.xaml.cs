using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PubgNet;

using PubgStat.view_model;
using PubgStat.page;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PubgStat.page;

namespace PubgStat.page {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class search_page : ContentPage {

        PubgNetClient client = new PubgNetClient(GetApi());
        static string Name;
        public search_page() {
            InitializeComponent();
        }
       

        private async void search_button_Clicked(object sender,EventArgs e) {
            Name = entry_player_name.Text;
            await take_data();
            
            
            
            await Shell.Current.GoToAsync("//season_solo");

        }

        public static string GetApi() {
            return "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJqdGkiOiI0ZjYyODUxMC1kM2UwLTAxMzctZDdhNC0wZjNhMTg5NGE0ZTciLCJpc3MiOiJnYW1lbG9ja2VyIiwiaWF0IjoxNTcxNDA4NDA3LCJwdWIiOiJibHVlaG9sZSIsInRpdGxlIjoicHViZyIsImFwcCI6ImNpcGlkcmlzLWdtYWlsIn0.vTbdRV5CgGMOUUU7zDmMojlSULLafjhfFbBfEkbidjI";
        }
        public async Task take_data() {


            if(Name == null)
                await DisplayAlert("Уведомление","Введите ник игрока","ОK");
            else {

                var players = await client.GetPlayersByUsernames(new string[] { Name });
                if(players == null)
                    await DisplayAlert("Уведомление","Неверный  ник игрока","ОK");
                var seasons = await client.GetSeasons();
                string rank_pointss = "100",
                    swim_distt = "200";
                this.BindingContext = new data_page_view_model {
                    rank_points = rank_pointss,
                    swim_dist = swim_distt

                };



            }
        }

    }
}
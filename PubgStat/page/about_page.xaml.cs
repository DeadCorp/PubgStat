using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PubgStat.page {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class about_page : ContentPage {
        public about_page() {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender,EventArgs e) {
            await Browser.OpenAsync("https://github.com/DeadCorp/PubgStat");
            
        }
        private async void Button_Clicked_1(object sender,EventArgs e) {
            await Browser.OpenAsync("https://documentation.pubg.com/en/introduction.html");
        }
        private async void Button_Clicked_4(object sender,EventArgs e) {
            await Browser.OpenAsync("https://github.com/pubg/api-assets");
        }
        private async void Button_Clicked_7(object sender,EventArgs e) {
            await Browser.OpenAsync("https://docs.microsoft.com/ru-ru/dotnet/csharp/");
        }
        private async void Button_Clicked_2(object sender,EventArgs e) {
            await Browser.OpenAsync("https://jsonapi.org/");
        }
        private async void Button_Clicked_5(object sender,EventArgs e) {
            await Browser.OpenAsync("https://jwt.io/");
        }
        private async void Button_Clicked_8(object sender,EventArgs e) {
            await Browser.OpenAsync("https://docs.microsoft.com/ru-ru/xamarin/xamarin-forms/");
        }
        private async void Button_Clicked_3(object sender,EventArgs e) {
            await Browser.OpenAsync("https://habr.com/ru/post/215117/");
        }
        private async void Button_Clicked_6(object sender,EventArgs e) {
            await Browser.OpenAsync("https://www.tutorialspoint.com/http/http_requests.htm");
        }
        private async void Button_Clicked_9(object sender,EventArgs e) {
            await Browser.OpenAsync("https://metanit.com/sharp/xamarin/");
        }
        private async void Button_Clicked_10(object sender,EventArgs e) {
            await Browser.OpenAsync("https://chdtu.edu.ua/");
        }
        private async void Button_Clicked_11(object sender,EventArgs e) {
            await Browser.OpenAsync("https://www.instagram.com/dpi_nikolay/?hl=uk");
        }

        async void OnSwiped(object sender,SwipedEventArgs e) {
            switch(e.Direction) {

                case SwipeDirection.Left:
               // await Shell.Current.GoToAsync("//a");
                break;
                case SwipeDirection.Right:
                await Shell.Current.GoToAsync("//l_sqt");
                break;

            }
        }
    }
}
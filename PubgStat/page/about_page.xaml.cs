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

    }
}
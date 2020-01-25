using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PubgStat.view_model;
using Xamarin.Forms;


using Xamarin.Forms.Xaml;

namespace PubgStat.page.season_stat_page {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class data_page_squad_tpp : ContentPage {
        private data_page_view_model vm =  new data_page_view_model();
        private Image temp = new Image();
        public  data_page_squad_tpp() {
            InitializeComponent();
            temp.Source = ImageSource.FromResource("PubgStat.Ranks.Unknown.png");
            vm.image = temp;
            this.BindingContext = vm;
            MessagingCenter.Subscribe<search_page,data_page_view_model>(this,"data_sq_t",(sender, arg) => {
                this.BindingContext = arg;
            });
        }


        async void OnSwiped(object sender,SwipedEventArgs e) {
            switch(e.Direction) {

                case SwipeDirection.Left:
                await Shell.Current.GoToAsync("//l_s");
                break;
                case SwipeDirection.Right:
                await Shell.Current.GoToAsync("//s_dt");
                break;

            }
        }

    }
}
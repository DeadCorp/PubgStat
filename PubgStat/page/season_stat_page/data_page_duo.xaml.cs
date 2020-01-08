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
    public partial class data_page_duo : ContentPage {
        private data_page_view_model vm =  new data_page_view_model();
        private Image temp = new Image();
        public data_page_duo() {
            InitializeComponent();

            temp.Source = ImageSource.FromResource("PubgStat.Ranks.Unknown.png");
            vm.image = temp;
            this.BindingContext = vm;
            MessagingCenter.Subscribe<search_page,data_page_view_model>(this,"data_d",(sender, arg) => {
                this.BindingContext = arg;
            });
        }
        


     
    }
}
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
    public partial class data_page_solo : ContentPage {
        private data_page_view_model vm =  search_page.solo_fpp_vm;
        
        public  data_page_solo() {
            InitializeComponent();
            
        }
        


        private void ContentPage_Appearing(object sender,EventArgs e) {
           
               
                this.BindingContext = vm;
            
        }
    }
}
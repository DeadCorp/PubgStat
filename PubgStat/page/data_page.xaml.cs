using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PubgStat.view_model;
using Xamarin.Forms;


using Xamarin.Forms.Xaml;

namespace PubgStat.page {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class data_page : ContentPage {

        
        public  data_page() {
            InitializeComponent();


            this.BindingContext = new data_page_view_model();
        }

        private void searchx_button_Clicked(object sender,EventArgs e) {

           

        }
        
    }
}
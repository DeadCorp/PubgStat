﻿using System;
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

            this.BindingContext = new data_page_view_model {
                rank_points = "10102342342",
                swim_dist = "232424"

            };

        }
        public static  void bind_s(data_page_view_model data) {

            bind(data);
        }
        private  static void bind(data_page_view_model view) {
            
           
                Shell.Current.BindingContext = view;
            
        }
        public static void bind_d() {

        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PubgStat.view_model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PubgStat.page.lifetime_stat_page {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class lifetime_page_solo_tpp : ContentPage {
        private data_page_view_model vm =  new data_page_view_model();
        public lifetime_page_solo_tpp() {
            InitializeComponent();
            this.BindingContext = vm;
            MessagingCenter.Subscribe<search_page,data_page_view_model>(this,"data_ls_t",(sender,arg) => {
                this.BindingContext = arg;
            });
        }
        async void OnSwiped(object sender,SwipedEventArgs e) {
            switch(e.Direction) {
                case SwipeDirection.Left:
                await Shell.Current.GoToAsync("//l_dt");
                break;
                case SwipeDirection.Right:
                await Shell.Current.GoToAsync("//l_sq");
                break;

            }
        }
    }
    
}
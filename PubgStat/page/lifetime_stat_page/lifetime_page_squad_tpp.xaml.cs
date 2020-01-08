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
    public partial class lifetime_page_squad_tpp : ContentPage {
        private data_page_view_model vm =  new data_page_view_model();
        public lifetime_page_squad_tpp() {
            InitializeComponent();
            this.BindingContext = vm;
            MessagingCenter.Subscribe<search_page,data_page_view_model>(this,"data_lsq_t",(sender,arg) => {
                this.BindingContext = arg;
            });
        }
    }
    
}
using System;
using PubgStat.model;
using PubgStat.page;
using PubgStat.view_model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PubgStat {
    public partial class App : Application {
        public static Page main_page = new MainPage();
        public static Page data_page = new data_page();
        public static Page search_page = new search_page();
        public App() {
            InitializeComponent();

            MainPage = main_page;
            main_page.BindingContext = new data_page_view_model();
        }
        public static Page getda() { return data_page; }
        public static Page getse() { return search_page; }
        protected override void OnStart() {
        }

        protected override void OnSleep() {
        }

        protected override void OnResume() {
        }
    }
}

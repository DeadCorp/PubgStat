using System;
using PubgStat.page;
using PubgStat.view_model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PubgStat {
    public partial class App : Application {
        
        public App() {
            InitializeComponent();

            MainPage = new MainPage();
            
        }
        
        protected override void OnStart() {
        }

        protected override void OnSleep() {
        }

        protected override void OnResume() {
        }
    }
}

using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Mary_Wanna.Services;
using Mary_Wanna.Views;

namespace Mary_Wanna
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Test.Views;
using FreshMvvm;

namespace Test
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SplashScreen());

            ((NavigationPage)Current.MainPage).BarBackgroundColor = Color.FromHex("#654321");
            ((NavigationPage)Current.MainPage).BarTextColor = Color.White;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

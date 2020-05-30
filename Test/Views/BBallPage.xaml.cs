using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using Test.ViewModels;
using Test.Views.SubViews;
using Xamarin.Forms;

namespace Test.Views
{
    public partial class BBallPage : ContentPage
    {
        BBallViewModel ViewModel;
        public BBallPage()
        {
            InitializeComponent();

            ViewModel = Resources["vm"] as BBallViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var pop = new MessageBox();
            App.Current.MainPage.Navigation.PushPopupAsync(pop, true);
        }
    }
}

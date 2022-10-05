using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnBackButtonPressed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void DoSomething()
        {
            await DisplayAlert("Info", "OnBackButtonPressed", "OK");
            await Application.Current.MainPage.Navigation.PopAsync(); //Close this Page (Pop the page off the top of the navigation stack)
        }

        //this overrides the hardware back button (not the navigation bar back button)
        protected override bool OnBackButtonPressed()
        {
            base.OnBackButtonPressed();
            DoSomething();
            return true;
        }
    }
}
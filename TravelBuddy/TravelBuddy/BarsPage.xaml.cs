using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Plugin.TextToSpeech;
using Xamarin.Forms;

namespace TravelBuddy
{
    public partial class BarsPage : ContentPage
    {
        public BarsPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await OnStart();
        }

        private async Task OnStart()
        {
            await CrossTextToSpeech.Current.Speak("We have found 2 Bars near your location: Weatherspoons and Brewdog.");
        }

        async void OnWeatherClicked(object sender, EventArgs args)
        {
            await CrossTextToSpeech.Current.Speak("Finding route for Weatherspoons");
            await Navigation.PushAsync(new WalkingNavigation1Page());
        }

        async void OnBrewdogButtonClicked(object sender, EventArgs args)
        {
            await CrossTextToSpeech.Current.Speak("Finding route for Brew Dog");
            await Navigation.PushAsync(new WalkingNavigation1Page());
        }
    }
}

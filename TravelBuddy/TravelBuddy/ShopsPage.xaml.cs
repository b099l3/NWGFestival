using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Plugin.TextToSpeech;
using Xamarin.Forms;

namespace TravelBuddy
{
    public partial class ShopsPage : ContentPage
    {
        public ShopsPage()
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
            await CrossTextToSpeech.Current.Speak("We have found 3 shops near your location: WHSmith, Boots Pharmacy and Starbucks.");
        }

        async void OnWHSButtonClicked(object sender, EventArgs args)
        {
            await CrossTextToSpeech.Current.Speak("Finding route for WHSmiths");
            await Navigation.PushAsync(new WalkingNavigation1Page());
        }

        async void OnBootsButtonClicked(object sender, EventArgs args)
        {
            await CrossTextToSpeech.Current.Speak("Finding route for Boots");
            await Navigation.PushAsync(new WalkingNavigation1Page());
        }

        async void OnStarbucksButtonClicked(object sender, EventArgs args)
        {
            await CrossTextToSpeech.Current.Speak("Finding route for Starbucks");
            await Navigation.PushAsync(new WalkingNavigation1Page());
        }
    }
}

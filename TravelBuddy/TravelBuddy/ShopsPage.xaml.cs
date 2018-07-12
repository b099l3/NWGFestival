using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Plugin.TextToSpeech;
using Xamarin.Forms;

namespace TravelBuddy
{
    public partial class ShopsPage : ContentPage
    {
        private bool isFirstRun = true;

        public ShopsPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if (isFirstRun)
            {
                await OnStart();
            }
        }

        private async Task OnStart()
        {
            await CrossTextToSpeech.Current.Speak("We have found 3 shops near your location: WHSmith, Boots Pharmacy and Starbucks.");
            isFirstRun = false;
        }

        async void OnBackButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }

        async void OnWHSButtonClicked(object sender, EventArgs args)
        {
            await CrossTextToSpeech.Current.Speak("Finding route for WHSmith");
            await Navigation.PushModalAsync(new WalkingNavigation1Page());
        }

        async void OnBootsButtonClicked(object sender, EventArgs args)
        {
            await CrossTextToSpeech.Current.Speak("Finding route for Boots");
            await Navigation.PushModalAsync(new WalkingNavigation1Page());
        }

        async void OnStarbucksButtonClicked(object sender, EventArgs args)
        {
            await CrossTextToSpeech.Current.Speak("Finding route for Starbucks");
            await Navigation.PushModalAsync(new WalkingNavigation1Page());
        }
    }
}

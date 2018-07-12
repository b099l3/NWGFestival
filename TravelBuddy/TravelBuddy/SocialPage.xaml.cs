using System;
using System.Collections.Generic;
using Plugin.TextToSpeech;
using Xamarin.Forms;

namespace TravelBuddy
{
    public partial class SocialPage : ContentPage
    {
        public SocialPage()
        {
            InitializeComponent();
        }

        async void OnShopsButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new ShopsPage());
        }

        async void OnBarsButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new BarsPage());
        }

        async void OnToiletsButtonClicked(object sender, EventArgs args)
        {
            await CrossTextToSpeech.Current.Speak("Finding route to nearest toilet");
            await Navigation.PushModalAsync(new WalkingNavigation1Page());
        }

        async void OnBackButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }

        async void OnSoloTravellersButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new SoloTravellerPage());
        }

    }
}

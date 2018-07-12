using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
            await Navigation.PushModalAsync(new ToiletsPage());
        }

        async void OnBackButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }

        async void OnSoloTravellersButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new SoloTravellerPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            OnStart();
        }

        private async Task OnStart()
        {
            await CrossTextToSpeech.Current.Speak("See what shops, bars and restaurants we have on offer in Newcastle Airport, or we can tell you where the nearest toilet is or find you some solo Travel Buddies.");
        }

    }
}

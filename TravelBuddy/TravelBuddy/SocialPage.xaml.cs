using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Plugin.TextToSpeech;
using Xamarin.Forms;

namespace TravelBuddy
{
    public partial class SocialPage : ContentPage
    {
        private bool isFirstRun = true;
        private bool canNavigate;

        public SocialPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
        }

        async void OnShopsButtonClicked(object sender, EventArgs args)
        {
            if (canNavigate)
            {
                await Navigation.PushAsync(new ShopsPage());
            }
        }

        async void OnBarsButtonClicked(object sender, EventArgs args)
        {
            if (canNavigate)
            {
                await Navigation.PushAsync(new BarsPage());
            }
        }

        async void OnToiletsButtonClicked(object sender, EventArgs args)
        {
            if (canNavigate)
            {
                await CrossTextToSpeech.Current.Speak("Finding route to nearest toilet");
                await Navigation.PushAsync(new WalkingNavigation1Page());
            }
        }

        async void OnSoloTravellersButtonClicked(object sender, EventArgs args)
        {
            if (canNavigate)
            {
                await Navigation.PushModalAsync(new SoloTravellerPage());
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (isFirstRun)
            {
                OnStart();
            }
        }

        private async Task OnStart()
        {
            await CrossTextToSpeech.Current.Speak("See what shops, bars and restaurants we have on offer in Newcastle Airport, or we can tell you where the nearest toilet is or find you some solo Travel Buddies.");
            isFirstRun = false;
            canNavigate = true;
            NavigationPage.SetHasBackButton(this, true);
        }

    }
}

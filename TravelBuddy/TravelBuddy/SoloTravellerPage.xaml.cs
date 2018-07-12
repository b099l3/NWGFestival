using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Plugin.TextToSpeech;
using Xamarin.Forms;

namespace TravelBuddy
{
    public partial class SoloTravellerPage : ContentPage
    {
        public SoloTravellerPage()
        {
            InitializeComponent();
        }

        async void OnConnectButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SoloTravellersConnectPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            OnStart();
        }

        private async Task OnStart()
        {
            await CrossTextToSpeech.Current.Speak("There are 3 other Travel Buddies in the airport that you could connect with.");
        }
    }
}

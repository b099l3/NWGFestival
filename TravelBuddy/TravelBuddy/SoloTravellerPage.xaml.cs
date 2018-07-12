﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Plugin.TextToSpeech;
using Xamarin.Forms;

namespace TravelBuddy
{
    public partial class SoloTravellerPage : ContentPage
    {
        private bool canNavigate;
        private bool isFirstRun = true;

        public SoloTravellerPage()
        {
            InitializeComponent();
        }

        async void OnConnectButtonClicked(object sender, EventArgs args)
        {
            if (canNavigate)
            {
                await Navigation.PushModalAsync(new SoloTravellersConnectPage());
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
            await CrossTextToSpeech.Current.Speak("There are 3 other Travel Buddies in the airport that you could connect with.");
            canNavigate = true;
            isFirstRun = false;
        }
    }
}

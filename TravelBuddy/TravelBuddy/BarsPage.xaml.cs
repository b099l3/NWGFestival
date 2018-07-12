﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Plugin.TextToSpeech;
using Xamarin.Forms;

namespace TravelBuddy
{
    public partial class BarsPage : ContentPage
    {
        private bool isFirstRun = true;
        private bool canNavigate;

        public BarsPage()
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
            await CrossTextToSpeech.Current.Speak("We have found 2 Bars near your location: Weatherspoons and Brewdog.");
            canNavigate = true;
            isFirstRun = false;
        }

        async void OnBackButtonClicked(object sender, EventArgs args)
        {
            if (canNavigate)
            {
                await Navigation.PopModalAsync();
            }
        }

        async void OnWeatherClicked(object sender, EventArgs args)
        {
            if (canNavigate)
            {
                await CrossTextToSpeech.Current.Speak("Finding route for Weatherspoons");
                await Navigation.PushModalAsync(new WalkingNavigation1Page());
            }
        }

        async void OnBrewdogButtonClicked(object sender, EventArgs args)
        {
            if (canNavigate)
            {
                await CrossTextToSpeech.Current.Speak("Finding route for Brew Dog");
                await Navigation.PushModalAsync(new WalkingNavigation1Page());
            }
        }
    }
}

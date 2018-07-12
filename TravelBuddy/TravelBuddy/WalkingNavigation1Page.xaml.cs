using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Plugin.TextToSpeech;
using Xamarin.Forms;

namespace TravelBuddy
{
    public partial class WalkingNavigation1Page : ContentPage
    {
        private bool canNavigate;

        public WalkingNavigation1Page()
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
            await WalkingDirections(3);
            await CrossTextToSpeech.Current.Speak("You have arrived!");
            WalkingLabel.Text = "You have arrived!";
            canNavigate = true;
        }

        async void OnBackButtonClicked(object sender, EventArgs args)
        {
            if (canNavigate)
            {
                await Navigation.PopModalAsync();
            }
        }

        static Random rnd = new Random();

        async Task WalkingDirections(int numberOfDirections)
        {
            for (int i = 0; i < numberOfDirections; i++)
            {
                var directions = new List<string>{ "Walk forward", "Take a left", "your next right"};
                int r = rnd.Next(directions.Count);
                var randomDirection = directions[r];
                WalkingLabel.Text = randomDirection;
                await CrossTextToSpeech.Current.Speak(randomDirection);
                await Task.Delay(1000);
            }
        }
    }
}

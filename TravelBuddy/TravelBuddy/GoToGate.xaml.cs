using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Plugin.TextToSpeech;
using Plugin.Vibrate;
using Xamarin.Forms;

namespace TravelBuddy
{
    public partial class GoToGate : ContentPage
    {
        public GoToGate()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            OnStart();
        }

        private async Task OnStart()
        {
            await CrossTextToSpeech.Current.Speak("We have your current location, stay where you are and help will be with you soon.");

            await Task.Delay(2500);

            var v = CrossVibrate.Current;
            v.Vibration(TimeSpan.FromSeconds(1));

            await CrossTextToSpeech.Current.Speak("Help has arrived.");
        }
    }
}

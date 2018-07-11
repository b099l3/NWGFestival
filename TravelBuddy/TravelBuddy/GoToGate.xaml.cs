using System;
using System.Collections.Generic;
using Plugin.TextToSpeech;
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

            CrossTextToSpeech.Current.Speak("Text to speak");
        }
    }
}

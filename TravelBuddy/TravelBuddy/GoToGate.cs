using System;

using Xamarin.Forms;

namespace TravelBuddy
{
    public class GoToGate : ContentPage
    {
        public GoToGate()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "HELP IS 6 MINUTES AWAY AND YOUR FLIGHT IS IN 30 MINUTES." }
                }
            };
        }
    }
}


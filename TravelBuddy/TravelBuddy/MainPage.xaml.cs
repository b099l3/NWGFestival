using System;
using Xamarin.Forms;

namespace TravelBuddy
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnSocialButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new SocialPage());
        }

        async void OnGateButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new GoToGate());
        }
    }
}

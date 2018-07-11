using System;
using System.Collections.Generic;

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
            await Navigation.PushModalAsync(new SocialPage());
        }

        async void OnBarsButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new SocialPage());
        }

        async void OnToiletsButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new SocialPage());
        }
    }
}

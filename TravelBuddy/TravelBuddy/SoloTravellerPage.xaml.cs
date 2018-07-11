using System;
using System.Collections.Generic;

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
            await Navigation.PushModalAsync(new SoloTravellersConnectPage());
        }
    }
}

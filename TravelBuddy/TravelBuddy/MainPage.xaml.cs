using System;
using System.Threading.Tasks;
using Plugin.TextToSpeech;
using Xamarin.Forms;

namespace TravelBuddy
{
    public partial class MainPage : ContentPage
    {
        private bool isFirstRun = true;
        private bool canNavigate;

        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
        }

        async void OnSocialButtonClicked(object sender, EventArgs args)
        {
            if (canNavigate)
            {
                await Navigation.PushAsync(new SocialPage());
            }
        }

        async void OnGateButtonClicked(object sender, EventArgs args)
        {
            if (canNavigate)
            {
                await Navigation.PushModalAsync(new GoToGate());
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
            await CrossTextToSpeech.Current.Speak("Welcomne to Newcastle Airport, do you want to go to your gate or socialize?");
            isFirstRun = false;
            canNavigate = true;
            NavigationPage.SetHasBackButton(this, true);
        }
    }
}

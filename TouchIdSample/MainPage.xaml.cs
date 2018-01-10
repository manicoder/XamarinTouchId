using System;
using System.Collections.Generic;
using Plugin.Fingerprint;
using Xamarin.Forms;

namespace TouchIdSample
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            FingerPrintLogin();
        }

        private async void FingerPrintLogin()
        {
            var result = await CrossFingerprint.Current.IsAvailableAsync();
            if (result)
            {
                var FPCancellationToken = new System.Threading.CancellationToken();
                var Auth = await CrossFingerprint.Current.AuthenticateAsync("Login for BingBing", FPCancellationToken);
                if (Auth.Authenticated)
                {
                    this.Navigation.PushAsync(new SuccessPage());
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("", "Authentication fails", "Ok");
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("", "Finger print feature is not available in mobile...", "Ok");

            }

        }
    }
}

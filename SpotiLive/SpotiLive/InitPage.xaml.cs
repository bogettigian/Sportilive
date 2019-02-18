using System;
using Xamarin.Forms;

namespace SpotiLive
{
    public partial class InitPage : ContentPage
    {
        public InitPage()
        {
            InitializeComponent();
        }

        private void Signup_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SignPage(false));
        }

        private void Signin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SignPage(true));
        }
    }
}

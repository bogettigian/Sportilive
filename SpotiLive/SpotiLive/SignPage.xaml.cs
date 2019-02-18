using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpotiLive
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignPage : ContentPage
	{
        private bool _IsSignIn { get; set; }

        public SignPage ()
        {
            InitializeComponent();
        }

        public SignPage (bool isSignIn)
		{
			InitializeComponent ();

            _IsSignIn = isSignIn;

            if(_IsSignIn)
            {
                txtForgotPass.Text = "Forgot password? Click Here";
                txtForgotPass.GestureRecognizers.Add(new TapGestureRecognizer((view) => TxtForgotPass_Clicked()));
                btnSign.Text = "SIGN IN";
                btnSign.BackgroundColor = Color.DarkOrange;
            }
		}

        private void Sign_Clicked(object sender, EventArgs e)
        {
            string email = entryEmail.Text;
            string pass = entryPass.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass))
            {
                DisplayAlert("Error", "Los datos ingresados son invalidos", "Accept");
                return;
            }

            if(_IsSignIn)
            {
                //TODO: FireBase Authentication login
                this.Navigation.PushModalAsync(new MainPage());
            }
            else
            {
                //TODO: FireBase Authentication register
                this.Navigation.PushModalAsync(new InitPage());
            }
        }

        private void TxtForgotPass_Clicked()
        {
            DisplayAlert("Recovery", "Jajaja te olvidaste la contraseña", "Accept");
        }
    }
}
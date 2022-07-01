using Prototype.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Prototype
{
    /// <summary>
    /// This is the login Page which will navigate to the HomePage if the user has logged in.
    /// The profile page will come in later.
    /// There are also links that link to a SignUp page and A ForgottenPassword Page, for now those pages
    /// won't do anything.
    /// </summary>
    public partial class MainPage : ContentPage
    {
        //public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        async void CreateAccountTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUp());
        }

        private async void LoginClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }

        //Forgotten Password will just navigate to home for now
        private async void ForgotPasswordClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prototype.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        /// <summary>
        /// Parent Home page. For no this will only display the child progress.
        /// The Home Page Will have a list view for the children as well 
        /// as a settings icon, profile icon and the ability to change between
        /// </summary>

        public HomePage()
        {
            InitializeComponent();
        }

        //public ObservableChildren<ViewProgress> ViewProgress { get; set; }

        private async void ProfileClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfilePage());
        }

        private async void ViewProgressClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewProgress());
        }
    }
}
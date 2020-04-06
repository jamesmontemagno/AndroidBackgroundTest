using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AndroidBackgroundTest
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void CheckInUse_Clicked(object sender, EventArgs e)
        {
            var result = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();
            await DisplayAlert("Status", result.ToString(), "OK");
        }

        async void RequestInUse_Clicked(object sender, EventArgs e)
        {
            var result = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            await DisplayAlert("Status", result.ToString(), "OK");
        }

        async void CheckAlways_Clicked(object sender, EventArgs e)
        {
            var result = await Permissions.CheckStatusAsync<Permissions.LocationAlways>();
            await DisplayAlert("Status", result.ToString(), "OK");

        }

        async void RequestAlways_Clicked(object sender, EventArgs e)
        {
            var result = await Permissions.RequestAsync<Permissions.LocationAlways>();
            await DisplayAlert("Status", result.ToString(), "OK");
        }
    }
}

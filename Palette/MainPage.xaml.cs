using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Palette
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int count = 0;

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
           
        }

        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sign_Up());
            
        }
        private async void NavigateButton_Preference(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pref());
        }



    }
}

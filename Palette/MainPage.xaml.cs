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

        void Handle_Clicked(object sender, System.EventArgs e)
        {

            count = count + 69;
            ((Button)sender).Text = $"You aroused me {count} times";
        }

        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sign_Up());
        }
    }
}

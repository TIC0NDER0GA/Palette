using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Palette
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Preferences : ContentView
    {
        public Preferences()
        {
            InitializeComponent();
        }

        private async void NavigateButton_Categories(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sign_Up());
        }

        private async void NavigateButton_Main(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
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
    public partial class Pref : ContentPage
    {
        public Pref()
        {
            InitializeComponent();
        }

        private async void NavigateButton_Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void NavigateButton_Continue(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Categories());
        }
    }
}
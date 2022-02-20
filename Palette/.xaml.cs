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
    public partial class Sign_Up : ContentPage
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
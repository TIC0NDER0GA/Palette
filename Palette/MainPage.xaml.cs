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

  
        private async void APItry(object sender, EventArgs e)
        {
            Program.Main(recipeFoodName.Text);
            recipeFoodName.Text = "";
            Console.WriteLine(Program.Recipe());
            listRecipe.Text = Program.Recipe();


        }





    }
}

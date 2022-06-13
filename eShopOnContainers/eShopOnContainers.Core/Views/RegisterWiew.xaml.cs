using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eShopOnContainers.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterWiew : ContentPage
    {
        public RegisterWiew()
        {
            InitializeComponent();
        }
        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Account());
        }
    }
}
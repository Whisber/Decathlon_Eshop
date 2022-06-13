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
    public partial class Categories : ContentPage
    {
        public Categories()
        {
            InitializeComponent();
        }
       
        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {

            Navigation.PushAsync(new Erkek());

        }

        private void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Kadın());
        }
    }
}
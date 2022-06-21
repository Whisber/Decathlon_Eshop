using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eShopOnContainers.Core.Helpers;

namespace eShopOnContainers.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterWiew : ContentPage
    {
        IAuth auth;
        public RegisterWiew()
        {
            InitializeComponent();
            auth = DependencyService.Get<IAuth>();
        }
        async void SignUpClicked(object sender, EventArgs e)
        {
            var user = auth.SignUpWithEmailAndPassword(EmailInput.Text, PasswordInput.Text);
            if (user != null)
            {
                await DisplayAlert("Basarili", "Yeni kullanıcı eklendi.", "OK");
                var signOut = auth.SignOut();
                if (signOut)
                {
                    Application.Current.MainPage = new LoginView();
                }
            }
            else
            {
                await DisplayAlert("Hata", "Bir hata olustu.", "OK");
            }
        }
        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginView());
        }
    }
}
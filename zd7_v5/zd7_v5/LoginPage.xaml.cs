using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd7_v5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Button_ClickedAsync(object sender, EventArgs e)
        {

           
            string username = userLine.Text;

            string password = passLine.Text;

           
            if (username != "ects" || password != "ects2024")
            {
               
                await DisplayAlert("ошибка", "неправильный логин или пароль", "OK");
            }
            else
            {

               
                await Navigation.PushAsync(new ThirdPage());
            }
        }
    }
}
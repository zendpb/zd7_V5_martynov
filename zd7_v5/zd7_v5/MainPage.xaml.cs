using System.Xml;
using System;

using Xamarin.Forms;

namespace zd7_v5
{
    public partial class MainPage : ContentPage
    {
        public MainPage(Dom dom1)
        {
            InitializeComponent();

            
            BindingContext = dom1;
        }

        private async void OnCalculatePaymentClicked(object sender, EventArgs e)
        {
            
            await Navigation.PushAsync(new ModalPage());
        }

        private async void OnReturnToMainPageClicked(object sender, EventArgs e)
        {
            
            await Navigation.PopAsync();
        }
    }
}
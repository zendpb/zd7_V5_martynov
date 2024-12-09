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
    public partial class ModalPage : ContentPage
    {
        public ModalPage()
        {
            InitializeComponent();
        }

        private void OnCalculateClicked(object sender, EventArgs e)
        {
            
            double price = double.Parse(PriceEntry.Text);
            string paymentType = PaymentTypePicker.SelectedItem.ToString();
            int paymentTerm = int.Parse(PaymentTermEntry.Text);

            double discount = paymentType == "Наличный расчет" ? 0.9 : 1.1;
            double termMultiplier = paymentTerm <= 4 ? 0.95 : paymentTerm <= 31 ? 1.1 : 1.15;

            double result = price * discount * termMultiplier;
            ResultLabel.Text = $"Итоговая сумма: {result}";
        }

        private async void OnReturnToRootClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ThirdPage());
        }

        private async void OnReturnToMainPageClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
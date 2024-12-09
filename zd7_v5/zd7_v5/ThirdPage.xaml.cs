using Xamarin.Forms;
using System.Collections.Generic;
using System;

namespace zd7_v5
{
    public partial class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            InitializeComponent();

           
            var domList = new List<Dom>
            {
                new Dom { Name = "Дом 1", Photo = "house1.jpg", Price = "100 000", Rooms = "3 комнаты" },
                new Dom { Name = "Дом 2", Photo = "house2.jpg", Price = "200 000", Rooms = "6 комнат" },
                new Dom { Name = "Дом 3", Photo = "house3.jpg", Price = "150 000", Rooms = "5 комнат" }
            };

            RealEstateCarouselView.ItemsSource = domList;
        }

        private async void OnViewDetailsClicked(object sender, EventArgs e)
        {
            
            var button = sender as Button;
            var selectedRealEstate = button?.BindingContext as Dom;

            if (selectedRealEstate != null)
            {
                await Navigation.PushAsync(new MainPage(selectedRealEstate));
            }
        }
    }

    public class Dom
    {
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Price { get; set; }
        public string Rooms { get; set; }
    }
}
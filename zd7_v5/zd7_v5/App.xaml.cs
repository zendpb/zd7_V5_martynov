﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd7_v5
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            
            MainPage = new NavigationPage(new LoginPage());

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

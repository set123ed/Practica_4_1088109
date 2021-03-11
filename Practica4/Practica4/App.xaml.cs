﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Practica4.Views;

namespace Practica4
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new RegisterPage());
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

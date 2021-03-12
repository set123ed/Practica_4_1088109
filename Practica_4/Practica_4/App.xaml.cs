using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Practica_4.Views;

namespace Practica_4
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ContacsPage());
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

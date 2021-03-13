using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Contacts.Views;

namespace Contacts
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage( new ContactHomePage());
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

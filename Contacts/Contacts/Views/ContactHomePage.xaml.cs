using System;
using System.Collections.Generic;

using Contacts.ViewModel;

using Xamarin.Forms;

namespace Contacts.Views
{
    public partial class ContactHomePage : ContentPage
    {
        public ContactHomePage()
        {
            InitializeComponent();
            BindingContext = new ContactHomeViewModel();
            LoadData();
        }

        private void LoadData()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Contacts.Models;
using Xamarin.Forms;
using Xamarin.Essentials;
using Contacts.ViewModel;

namespace Contacts.Views
{
    public partial class AddContactPage : ContentPage
    {
        public AddContactPage(ObservableCollection<Models.Contact> contactsList)
        {
            InitializeComponent();
            BindingContext = new AddContactViewModel(contactsList);
        }
    }
}

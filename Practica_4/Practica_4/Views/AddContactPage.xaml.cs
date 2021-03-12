﻿
using System.Collections.ObjectModel;
using Practica_4.models;
using Practica_4.ViewModel;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Practica_4.Views
{
    public partial class AddContactPage : ContentPage
    {
        public AddContactPage(ObservableCollection<Contact> contactsList)
        {
            InitializeComponent();
            BindingContext = new AddContactViewModel(contactsList);
        }

    }
}

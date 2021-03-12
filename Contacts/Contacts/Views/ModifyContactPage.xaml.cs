using System;
using System.Collections.Generic;
using Contacts.ViewModel;
using Contacts.Models;


using Xamarin.Forms;

namespace Contacts.Views
{
    public partial class ModifyContactPage : ContentPage
    {
        public ModifyContactPage(Contact contact)
        {
            InitializeComponent();
            BindingContext = new ModifyContactViewModel(contact);
        }
    }
}

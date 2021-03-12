using System;
using System.Collections.Generic;
using Practica_4.models;
using Practica_4.ViewModel;

using Xamarin.Forms;

namespace Practica_4.Views
{
    public partial class ModifyContactPage : ContentPage
    {
        public ModifyContactPage(Contact contact )
        {
            InitializeComponent();
            BindingContext = new ModifyContactViewModel(contact);
        }
    }
}

using System;
using System.Collections.Generic;
using Practica4.ViewModels;

using Xamarin.Forms;

namespace Practica4.Views
{
    public partial class SignUpContactPage : ContentPage
    {
        public SignUpContactPage()
        {
            InitializeComponent();
            BindingContext = new AddContactViewModel();
        }
    }
}

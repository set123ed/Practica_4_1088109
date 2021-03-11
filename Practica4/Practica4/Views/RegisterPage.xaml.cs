using System;
using System.Collections.Generic;
using Practica4.ViewModels;

using Xamarin.Forms;

namespace Practica4.Views
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            BindingContext = new ContactViewModel();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Practica_4.ViewModel;

using Xamarin.Forms;

namespace Practica_4.Views
{
    public partial class ContacsPage : ContentPage
    {
        public ContacsPage()
        {
            InitializeComponent();
            BindingContext = new ContactViewModel();


        }
    }
}
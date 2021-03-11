using System;
using Practica4.Views;
using Practica4.Models;
using Practica4.Models;
using Practica4.Views;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;


namespace Practica4.ViewModels

{
    public class AddContactViewModel
    { 
     public ICommand AddContactCommand { get; }

    
        public AddContactViewModel()
        {
            AddContactCommand = new Command(OnAddContactCommand);
        }


        private async void OnAddContactCommand()
        {
            //    //await App.Current.MainPage.DisplayPromptAsync("add character", "Type the name ", "ok");
            await App.Current.MainPage.DisplayAlert("succesfull", "Contact added", "OK");
        }
    }

}


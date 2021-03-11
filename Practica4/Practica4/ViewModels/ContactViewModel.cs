using System;
using Practica4.Models;
using Practica4.Views;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace Practica4.ViewModels

{
    public class ContactViewModel
    {
        public IList<Contact> Contacts { get; }

        public ICommand Addcontact { get; }
 
        public ContactViewModel()
        {

            

            Addcontact = new Command(OnAddContact);

        }

        private async void OnAddContact()
        { 
        //    //await App.Current.MainPage.DisplayPromptAsync("add character", "Type the name ", "ok");
        await App.Current.MainPage.Navigation.PushAsync(new SignUpContactPage());
        }

    }
}

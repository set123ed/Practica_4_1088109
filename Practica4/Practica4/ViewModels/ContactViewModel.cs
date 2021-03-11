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

        public ICommand AddCommand { get; }
 
        public ContactViewModel()
        {

         //   AddCommand = new Command(AddContact);

           // Contacts = new List<Contact>
            //{ new Contact ( "Eduardo", "8093334444")};

        }

      //  private async void AddContact
       // {
         //   await Application.Current.MainPage.Navigation.PushAsync(new RegisterPage());
       // }

    }
}

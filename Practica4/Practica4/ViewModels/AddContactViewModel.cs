using System;
using Practica4.Views;
using Practica4.Models;
using Practica4.Models;
using Practica4.Views;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Practica4.ViewModels

{
    public class AddContactViewModel : INotifyPropertyChanged
    { 
     public ICommand AddContactCommand { get; }
     public Contact newContact { get; set; } = new Contact();
     public event PropertyChangedEventHandler PropertyChanged;

    public AddContactViewModel(ObservableCollection<Contact> contactList)
        {
            newContactCommand = new Command(async () => 
            

        //private async void OnAddContactCommand()

        //{

        //    //    //await App.Current.MainPage.DisplayPromptAsync("add character", "Type the name ", "ok");
        //        contactList.Add(newContact);
            

        }
    }

}


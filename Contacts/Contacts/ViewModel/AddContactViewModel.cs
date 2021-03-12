using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Contacts.Models;
using Xamarin.Forms;


namespace Contacts.ViewModel
{
    public class AddContactViewModel
    {
        public ICommand AddCommand { get; set; }
        public Contact nContact { get; set; } = new Contact();
        public event PropertyChangedEventHandler PropertyChanged;


        public AddContactViewModel(ObservableCollection<Contact> contactsList)
        {
            AddCommand = new Command(async () =>
            {
                    contactsList.Add(nContact);
                await App.Current.MainPage.DisplayAlert("Great", $"Contact {nContact.Name} added ", "Ok");
                await App.Current.MainPage.Navigation.PopAsync();
            });

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Windows.Input;
using Practica_4.models;
using Xamarin.Forms;
using Practica_4.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Essentials;


namespace Practica_4.ViewModel
{
    public class ContactViewModel : INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<models.Contact> Contacts { get; set; } = new ObservableCollection<models.Contact>();

        public ICommand DeleteContactCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand MoreOptionsCommand { get; set; }


        public ContactViewModel()
        {
            AddCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new AddContactPage(Contacts), false);
            });
            DeleteContactCommand = new Command<models.Contact>((param) =>
            {
                Contacts.Remove(param);
            });
            MoreOptionsCommand = new Command<models.Contact>((param) =>
            {
                MoreOptions(param);
            });
        }
        async void MoreOptions(models.Contact selectedContact)
        {
            var selectedAction = await App.Current.MainPage.DisplayActionSheet(null, "Cancel", null, "Call", "Edit");

            //if (selectedAction == "Cancel")
            //{

            //}
            //else if (selectedAction == "Call")
            //{
            //    PhoneDialer.Open(selectedContact.Number);
            //}
            //else if (selectedAction == "Edit")
            //{
            //    await App.Current.MainPage.Navigation.PushAsync(new EditContactPage(selectedContact), false);
            //}


            switch (selectedAction)
            {
                case "Cancel":
                    break;
                case "Call":
                    try
                    {
                        PhoneDialer.Open(selectedContact.Number);
                    }
                    catch (ArgumentNullException anEx)
                    {
                        await App.Current.MainPage.DisplayAlert("Error", "Number was empty", "Cancel");
                    }
                    catch (FeatureNotSupportedException ex)
                    {
                        await App.Current.MainPage.DisplayAlert("Error", "Phone Dialer not supported in this phone", "Cancel");
                    }
                    break;
                case "Edit":
                    await App.Current.MainPage.Navigation.PushAsync(new ModifyContactPage(selectedContact), false);
                    break;
            }
        }
    }
}

















            //public event PropertyChangedEventHandler PropertyChanged;
            //public  ObservableCollection<models.Contact> Contacts { get; set; } = new ObservableCollection<models.Contact>();
            //public ICommand AddCommand { get; set; }
            ////public ICommand DeleteContactCommand { get; set; }
            ////public ICommand MoreOptionsCommand { get; set; }


            //public ContactViewModel()
            //{
            //    AddCommand = new Command(async () =>
            //    {
            //        await App.Current.MainPage.Navigation.PushAsync(new AddContactPage(Contacts));
            //    });

            //}
        




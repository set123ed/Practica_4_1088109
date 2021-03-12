﻿using System;
using System.ComponentModel;
using System.Windows.Input;
using Practica_4.models;
using Xamarin.Forms;

namespace Practica_4.ViewModel
{
    public class ModifyContactViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public Contact editC { get; set; } = new Contact();
        public ICommand EditContactCommand { get; set; }
        public ModifyContactViewModel(Contact contact)
        {
            editC.Name = contact.Name;
            editC.Number = contact.Number;
            EditContactCommand = new Command(() => EditContact(contact));
        }

        private async void EditContact(Contact contact)
        {
            contact.Name = editC.Name;
            contact.Number = editC.Number;
            await App.Current.MainPage.DisplayAlert("Success!", "Contact information has been changed", "OK");
        }









        //{
        //    public event PropertyChangedEventHandler PropertyChanged;
        //    public Contact editContact { get; set; } = new Contact();
        //    public ICommand EditContactCommand { get; set; }
        //    public EditContactPageViewModel(Contact contact)
        //    {
        //        editContact.Name = contact.Name;
        //        editContact.Number = contact.Number;
        //        EditContactCommand = new Command(async () =>
        //        {
        //            contact.Name = editContact.Name;
        //            contact.Number = editContact.Number;
        //            await App.Current.MainPage.DisplayAlert("Success!", "Contact information has been changed", "OK");
        //        });
        //    }
        //}
    }
}

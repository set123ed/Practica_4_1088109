using System;
using System.ComponentModel;
using System.Windows.Input;
using Practica_4.models;
using Xamarin.Forms;

namespace Practica_4.ViewModel
{
    public class ModifyContactViewModel
    {
        private Contact contact;

        public ModifyContactViewModel(Contact contact)
        {
            this.contact = contact;
        }

        public class EditContactPageViewModel : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;
            public Contact editContact { get; set; } = new Contact();
            public ICommand EditContactCommand { get; set; }
            public EditContactPageViewModel(Contact contact)
            {
                editContact.Name = contact.Name;
                editContact.Number = contact.Number;
                EditContactCommand = new Command(async () =>
                {
                    contact.Name = editContact.Name;
                    contact.Number = editContact.Number;
                    await App.Current.MainPage.DisplayAlert("Success!", "Contact information has been changed", "OK");
                });
            }
        }
    }
}

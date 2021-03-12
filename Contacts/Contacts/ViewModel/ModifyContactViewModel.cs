using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Contacts.Models;
using Contacts.Views;
namespace Contacts.ViewModel
{
    public class ModifyContactViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Contact editC { get; set; } = new Models.Contact();
        public ICommand EditContactCommand { get; set; }
        public ModifyContactViewModel(Contact contact)
        {
            editC.Name = contact.Name;
            editC.Number = contact.Number;
            EditContactCommand = new Command(() => EditContact(contact));
        }
        private async void EditContact(Models.Contact contact)
        {
            contact.Name = editC.Name;
            contact.Number = editC.Number;
            await App.Current.MainPage.DisplayAlert("Success!", "Contact information has been changed", "OK");
        }
    }
}

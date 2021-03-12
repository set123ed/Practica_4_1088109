
using System.ComponentModel;

using System.Windows.Input;
using Xamarin.Forms;
using Contacts.Models;
namespace Contacts.ViewModel
{
    public class ModifyContactViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Contact eContact { get; set; } = new Models.Contact();
        public ICommand ModifyContactCommand { get; set; }
        public ModifyContactViewModel(Contact contact)
        {
            eContact.Name = contact.Name;
            eContact.Number = contact.Number;
            ModifyContactCommand = new Command(() => ModifyContact(contact));
        }
        private async void ModifyContact(Models.Contact contact)
        {
            contact.Name = eContact.Name;
            contact.Number = eContact.Number;
            await App.Current.MainPage.DisplayAlert("Great", "Contact modified", "Ok");
        }
    }
}

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Contacts.Views;
using Contacts.ViewModel;
using Contacts.Models;
using System;

namespace Contacts.ViewModel
{
    public class ContactHomeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Models.Contact> Contacts { get; set; } = new ObservableCollection<Models.Contact>();

        public ICommand DeleteContactCommand { get; set; }

        public ICommand NewContactCommand { get; set; }

        public ICommand MoreOptionsCommand { get; set; }

        public ContactHomeViewModel()
        {
            NewContactCommand = new Command(OnNewContactCommand);
            //async () =>
            //{
            //    await App.Current.MainPage.Navigation.PushAsync(new AddContactPage(Contacts));
            //});
            DeleteContactCommand = new Command<Models.Contact>((param) =>
            {
                Contacts.Remove(param);
            });
            MoreOptionsCommand = new Command<Models.Contact>((param) =>
            {
                MoreOptions(param);
            });
        }

        private async void OnNewContactCommand()
        {
            await App.Current.MainPage.Navigation.PushAsync(new AddContactPage(Contacts));

        }


        async void MoreOptions(Models.Contact selectedContact)
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

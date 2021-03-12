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

        public ICommand OtherCommand { get; set; }
        public ICommand SelectedCommand { get; set; }

        private Xamarin.Essentials.Contact _selectitem;

        public Xamarin.Essentials.Contact SelectItem
        {
            get
            {
                return _selectitem;
            }

            set
            {
                _selectitem = value;
                if (_selectitem != null)
                {
                    SelectedCommand?.Execute(_selectitem);
                }
            }
        }

        public ContactHomeViewModel()
        {
            //SelectedCommand = new Command<Models.Contact>(MoreOptions);

            NewContactCommand = new Command(OnNewContactCommand);

            DeleteContactCommand = new Command<Models.Contact>((param) =>
            {
                Contacts.Remove(param);
            }); 
            OtherCommand = new Command<Models.Contact>((param) =>
            {
                MoreOptions(param);
            });

        }
        private async void OnNewContactCommand()
        {
            await App.Current.MainPage.Navigation.PushAsync(new AddContactPage(Contacts));
        }



        public async void MoreOptions(Models.Contact selectContact)
        {
            var selectedAction = await App.Current.MainPage.DisplayActionSheet( null,"Cancel",null, "Call", "Edit");

            if (selectedAction == "Cancel")
            {
                //cancel action
            }
            else if (selectedAction == "Call")
            {
                try
                {
                    PhoneDialer.Open(selectContact.Number);
                }
                catch (ArgumentNullException anEx)
                {
                    // Number was null or white space
                    await App.Current.MainPage.DisplayAlert("Null", "Number Empty", "Ok");
                }
                catch (FeatureNotSupportedException ex)
                {
                    // Phone Dialer is not supported on this device.
                }
               
            }
            else if (selectedAction == "Edit")
            {
                await App.Current.MainPage.Navigation.PushAsync(new ModifyContactPage(selectContact),false);
            }
        }
    }
}




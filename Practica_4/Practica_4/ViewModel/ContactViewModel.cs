using System;
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
        public static ObservableCollection<models.Contact> Contacts { get; set; } = new ObservableCollection<models.Contact>();
        public ICommand AddCommand { get; set; }
        public ICommand DeleteContactCommand { get; set; }
        public ICommand MoreOptionsCommand { get; set; }


        public ContactViewModel()
        {
            AddCommand = new Command(() => { OnAddContact(); });

        }

        public async void OnAddContact() {

            await App.Current.MainPage.Navigation.PushAsync(new ContacsPage());
        }
    }
}




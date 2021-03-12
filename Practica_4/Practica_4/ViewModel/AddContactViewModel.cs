using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using Practica_4.models;
using System.Collections.ObjectModel;



namespace Practica_4.ViewModel
{
    public class AddContactViewModel : INotifyPropertyChanged
    {

        public Contact newContact { get; set; } = new Contact();

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand AddCommand { get; set; }

        public AddContactViewModel(ObservableCollection<Contact> contactsList)
        {
            AddCommand = new Command(async () =>
            {

                if (!contactsList.Contains(newContact))
                {
                    contactsList.Add(newContact);
                    await App.Current.MainPage.DisplayAlert("Success!", "Contact has been added", "OK");
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Alert", "Contact already exists!", "OK");
                }


            });
        }
    }
}























    //public event PropertyChangedEventHandler PropertyChanged;
    //public ICommand AddCommand { get; set; }
    //public Contact nContact { get; set; } = new Contact();

    //public AddContactViewModel(ObservableCollection<Contact> contactAgendar)
    //{
    //    AddCommand = new Command(async() =>
    //    {
    //        //contactAgendar.Add(nContact);
    //        //await App.Current.MainPage.DisplayAlert("Good","Contact added", "Ok");
    //        //await App.Current.MainPage.Navigation.PopAsync();

    //        if (!contactAgendar.Contains(nContact))
    //        {
    //            contactAgendar.Add(nContact);
    //            await App.Current.MainPage.DisplayAlert("Success!", "Contact has been added", "OK");
    //        }
    //        else
    //        {
    //            await App.Current.MainPage.DisplayAlert("Alert", "Contact already exists!", "OK");
    //        }

    //    });
    //}
//}
//}
        //private async void OnAddContact()
        //{

        //    contactAgendar.Add(nContact);



        //    await App.Current.MainPage.DisplayAlert("Succesfull", "Contact Added", "Ok");
        //    ContactViewModel.Contacts.Add(new Contact(Contact.Name, Contact.Number));
        //    await App.Current.MainPage.Navigation.PopAsync();

        //}

    

                //};
                //}
                //private async void AddContacts()
                //{
                //    try
                //    {
                //        if (!contactsList.Contains(AddContact)) { }
                //        await App.Current.MainPage.DisplayAlert("Succesfull", "Contact added", "Ok");
                //        //Contacts.Add(new Contact());
                //        contactsList.Add(AddContact);

                //        else
                //        {
                //            await App.Current.MainPage.DisplayAlert("Alert", "Contact already exists!", "OK");
                //        }
                //    }
                //    }
                //}


using System;
using Practica4.Models;
using Practica4.Views;
using System.Collections.Generic;
namespace Practica4.ViewModels

{
    public class ContactViewModel
    {
        public IList<Contact> Contacts { get; }

        public ContactViewModel()
        {
            Contacts = new List<Contact>
            { new Contact ( "Eduardo", "8093334444")};

        }
    }
}

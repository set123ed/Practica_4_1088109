﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Essentials;
using Practica4.ViewModels;
using Practica4.Views;
namespace Practica4.Models

{
    public class Contact
    {
        public Contact()
        {
        }

        public Contact(string name, string telephone)
        {
            Name = name;
            Telephone = telephone;
        }

        public string Name { get; set; }
        public string Telephone { get; set;}

        internal static void add(object p)
        {
            throw new NotImplementedException();
        }

        internal static void Add(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
    

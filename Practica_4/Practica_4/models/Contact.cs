using System;
namespace Practica_4.models
{
    public class Contact

    {
        public Contact()
        {
        }

        public Contact(string name,string number)
        {
            Name = name;
            Number = number;
        }

        public string Name { get; set; }
        public string Number { get; set; }
    }
}

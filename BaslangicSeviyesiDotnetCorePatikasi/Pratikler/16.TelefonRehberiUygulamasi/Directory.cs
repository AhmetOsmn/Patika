using System;
using System.Collections.Generic;

namespace _16.TelefonRehberiUygulamasi
{
    public class Directory 
    {
        private List<Person> persons;

        public Directory()
        {
            persons = new List<Person>();
        }

        public List<Person> Persons { get => persons; set => persons = value; }
    }
}

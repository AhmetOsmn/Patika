using System;
using System.Collections.Generic;

namespace _16.TelefonRehberiUygulamasi
{
    public interface IDirectoryManager
    {
        void CreatePerson(Person person);
        void UpdatePerson(Person person);
        void DeletePerson(Person person);
        void ShowPersonsAsc();
        void ShowPersonsDesc();
        List<Person> SearchPerson(string nameOrSurname);
        List<Person> SearchPerson2(string number);
    }
}
using System;
using System.Collections.Generic;

namespace _16.TelefonRehberiUygulamasi
{
    public class DirectoryManager : IDirectoryManager
    {
        private List<Person> _persons;

        public DirectoryManager(Directory directory)
        {
            _persons = directory.Persons;
        }

        public void CreatePerson(Person person)
        {
            _persons.Add(person);
        }

        public void DeletePerson(Person person)
        {
            _persons.Remove(person);
        }

        public List<Person> SearchPerson(string nameOrSurname)
        {
            List<Person> matches = new List<Person>();
            foreach (var item in _persons)
            {

                if (item.Name.ToLower().Contains(nameOrSurname) || item.Surname.ToLower().Contains(nameOrSurname))
                {
                    matches.Add(item);
                }
            }
            return matches;
        }

        public List<Person> SearchPerson2(string number)
        {
            List<Person> matches = new List<Person>();
            foreach (var item in _persons)
            {

                if (item.Number == number)
                {
                    matches.Add(item);
                }
            }
            return matches;
        }

        public void ShowPersonsAsc()
        {
            List<Person> tempList = _persons;
            // tempList.Sort();

            foreach (var item in tempList)
            {
                PersonInfo(item);
            }

        }

        public void ShowPersonsDesc()
        {
            List<Person> tempList = _persons;
            // tempList.Sort();
            tempList.Reverse();

            foreach (var item in tempList)
            {
                PersonInfo(item);
            }
        }

        public void UpdatePerson(Person person)
        {
            Person tempPerson = _persons.Find(x => x.Name == person.Name && x.Surname == person.Surname);
            tempPerson.Number = person.Number;
        }

        private void PersonInfo(Person person)
        {
            System.Console.WriteLine("İsim: " + person.Name);
            System.Console.WriteLine("Soyisim: " + person.Surname);
            System.Console.WriteLine("Telefon Numarası: " + person.Number);
            System.Console.WriteLine("-");

        }
    }
}

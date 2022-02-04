using System;

namespace _16.TelefonRehberiUygulamasi
{
    public class Person
    {

        private string name;
        private string surname;
        private string number;

        public Person(string name, string surname, string number)
        {
            this.Name = name;
            this.Surname = surname;
            this.Number = number;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Number { get => number; set => number = value; }

        public void Info()
        {
            System.Console.WriteLine("İsim: " + this.name);
            System.Console.WriteLine("Soyisim: " + this.surname);
            System.Console.WriteLine("Telefon Numarası: " + this.number);
        }
    }
}
using System;
using System.Collections.Generic;

namespace _16.TelefonRehberiUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Ahmet", "SEZGİN", "000001");
            Person p2 = new Person("Ulaş", "AVİL", "000002");
            Person p3 = new Person("Kürşat", "GÜRLER", "000003");
            Person p4 = new Person("Mert", "ALTIN", "000004");
            Person p5 = new Person("Oğuzhan Emre", "DORAN", "000005");
            Person p6 = new Person("Burak", "GÜNEY", "000006");

            List<Person> personList = new List<Person>() { p1, p2, p3, p4, p5, p6 };

            System.Console.WriteLine("MENÜ");
            System.Console.WriteLine("----------------------------------------------");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            System.Console.WriteLine("----------------------------------------------");
        }
    }
}

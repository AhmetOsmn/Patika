using System;

namespace ConsoleProgramlama
{
    class Program
    {
        public static void Main(string[] args)
        {   
            Console.WriteLine("İsminizi girin: ");
            string name = Console.ReadLine();

            System.Console.WriteLine("Soyadınızı girin: ");
            string surname = Console.ReadLine();

            System.Console.WriteLine("Merhaba " + name + " " + surname);

        }
    }
}

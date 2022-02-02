using System;

namespace Soru4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle giriniz: ");

            string cumle = Console.ReadLine();
            string[] kelimeler = cumle.Split(" ");

            int toplamKelime = kelimeler.Length;
            int toplamHarf = 0;

            foreach (var item in kelimeler)
            {
                toplamHarf += item.Length;
            }

            System.Console.WriteLine("Kelime sayısı: {0}, harf sayısı: {1}",toplamKelime,toplamHarf);
        }
    }
}

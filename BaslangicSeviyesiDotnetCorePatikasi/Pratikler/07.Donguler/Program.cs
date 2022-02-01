using System;

namespace _07.Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekrandan girilen sayıya akdar olan tek sayıları ekrana yazdıralım.
            // System.Console.WriteLine("Bir sayı giriniz: ");
            // int sayac = int.Parse(Console.ReadLine());
            // for (int i = 1; i <= sayac; i++)
            // {
            //     if (i % 2 == 1)
            //     {
            //         System.Console.WriteLine("i: " + i);
            //     }
            // }

            // 1-1000 arasındaki tek ve çift sayıların toplamı
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tekToplam += i;
                }
                else
                {
                    ciftToplam += i;
                }
            }

            System.Console.WriteLine("Cift toplam: " + ciftToplam);
            System.Console.WriteLine("Tek toplam: " + tekToplam);

            // Eğer döngüyü kırmak istiyorsak break kullanırız. Sadece 1 döngüyü kırar. İç içe döngülerde sadece bulunduğu döngüyü kırar.
            // Eğer bir bloğun çalışmasını istemiyorsak, bloğun üst kısmında continue kullanırız.
        }
    }
}

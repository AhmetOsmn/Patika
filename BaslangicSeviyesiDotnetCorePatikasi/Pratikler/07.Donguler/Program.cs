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
            // int tekToplam = 0;
            // int ciftToplam = 0;
            // for (int i = 1; i <= 1000; i++)
            // {
            //     if (i % 2 == 1)
            //     {
            //         tekToplam += i;
            //     }
            //     else
            //     {
            //         ciftToplam += i;
            //     }
            // }
            // System.Console.WriteLine("Cift toplam: " + ciftToplam);
            // System.Console.WriteLine("Tek toplam: " + tekToplam);

            // Eğer döngüyü kırmak istiyorsak break kullanırız. Sadece 1 döngüyü kırar. İç içe döngülerde sadece bulunduğu döngüyü kırar.
            // Eğer bir bloğun çalışmasını istemiyorsak, bloğun üst kısmında continue kullanırız.

            // while
            // 1'den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp ekrana yazdıran program.
            // System.Console.WriteLine("Lutfen bir sayı giriniz: ");
            // int sayi = int.Parse(Console.ReadLine());
            // int sayac = 1;
            // float toplam = 0;
            // while(sayac <= sayi){
            //     toplam += sayac;
            //     sayac++; 
            // }
            // System.Console.WriteLine("Ortalama: " + (toplam/sayi));

            // 'a' dan 'z' ye kadar tüm harfleri ekrana yazdır.
            // char karakter = 'a';
            // while(karakter <= 'z'){
            //     System.Console.Write(karakter + " - ");
            //     karakter++;
            // }

            // Foreach
            string[] arabalar = {"BMW","Ford", "Mercedes","Toyota"};
            foreach (var araba in arabalar)
            {
                System.Console.WriteLine("Araba: " + araba);
            }




        }
    }
}

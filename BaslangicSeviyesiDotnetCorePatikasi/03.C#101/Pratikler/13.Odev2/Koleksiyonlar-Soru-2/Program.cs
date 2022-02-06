using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[20];

            int buyuklerToplam = 0;
            int kucuklerToplam = 0;

            System.Console.WriteLine("20 Adet sayı giriniz: ");
            for (int i = 0; i < 20; i++)
            {
                try
                {
                    System.Console.Write("{0}. sayı: ", i + 1);
                    int sayi = int.Parse(Console.ReadLine());
                    sayilar[i] = sayi;
                   
                }
                catch (System.Exception)
                {
                    System.Console.WriteLine("Geçersiz giriş: ");
                    i--;
                }
            }

            System.Console.WriteLine("\n");

            Array.Sort(sayilar);
            buyuklerToplam = sayilar[sayilar.Length-1] + sayilar[sayilar.Length-2] + sayilar[sayilar.Length-3]; // direk 19-18-17 de yazabiliriz.
            kucuklerToplam = sayilar[0] + sayilar[1] + sayilar[2];

            decimal buyuklerOrtalama = Convert.ToDecimal(buyuklerToplam) / Convert.ToDecimal(3);
            decimal kucuklerOrtalama = Convert.ToDecimal(kucuklerToplam) / Convert.ToDecimal(3);
            decimal toplam = buyuklerOrtalama + kucuklerOrtalama;
            System.Console.WriteLine("Küçükler ortalama: {0}, Büyükler ortalama: {1}, Ortalamaların toplamı: {2}",kucuklerOrtalama.ToString("#.##"),buyuklerOrtalama.ToString("#.##"),toplam.ToString("#.##"));
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList sayilar = new ArrayList();
            List<int> asallar = new List<int>();
            List<int> asalOlmayanlar = new List<int>();

            int asallarToplam = 0;
            int asalOlmayanlarToplam = 0;

            System.Console.WriteLine("20 Adet pozitif sayı giriniz: ");
            for (int i = 0; i < 20; i++)
            {
                try
                {
                    System.Console.Write("{0}. sayı: ", i+1);
                    int sayi = int.Parse(Console.ReadLine());
                    if (sayi <= 0)
                    {
                        System.Console.WriteLine("Lütfen pozitif sayi girin");
                    }
                    else
                    {
                        bool sonuc = asalMi(sayi);
                        if (sonuc)
                        {
                            asallar.Add(sayi);
                            asallarToplam += sayi;
                        }
                        else
                        {
                            asalOlmayanlar.Add(sayi);
                            asalOlmayanlarToplam += sayi;
                        }
                    }
                }
                catch (System.Exception)
                {
                    System.Console.WriteLine("Geçersiz giriş: ");
                    i--;
                }
            }

            asallar.Sort();
            asallar.Reverse();

            asalOlmayanlar.Sort();
            asalOlmayanlar.Reverse();
            
            decimal asallarOrtalama = Convert.ToDecimal(asallarToplam)/Convert.ToDecimal(asallar.Count);
            decimal asalOlmayanlarOrtalama = Convert.ToDecimal(asalOlmayanlarToplam)/Convert.ToDecimal(asalOlmayanlar.Count);
            System.Console.WriteLine("\n\n");
            System.Console.WriteLine("Asal sayıların sayısı: {0}, asal sayıların ortalaması: {1}",asallar.Count,asallarOrtalama.ToString("#.##"));
            System.Console.Write("Asal sayılar: ");
            foreach (var item in asallar)
            {
                System.Console.Write(item + " ");
            }
            System.Console.WriteLine("\n");

            System.Console.WriteLine("Asal olmayan sayıların sayısı: {0}, asal olmayan sayıların ortalaması: {1}",asalOlmayanlar.Count,asalOlmayanlarOrtalama.ToString("#.##"));
            System.Console.Write("Asal olmayan sayılar: ");
            foreach (var item in asalOlmayanlar)
            {
                System.Console.Write(item + " ");
            }
            System.Console.WriteLine("\n");

        }

        static bool asalMi(int sayi)
        {
            if (sayi == 1)
            {
                return false;
            }
            if (sayi == 2 || sayi == 3)
            {
                return true;
            }
            else
            {
                for (int i = 2; i < ((sayi / 2) + 1); i++)
                {
                    if (sayi % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}

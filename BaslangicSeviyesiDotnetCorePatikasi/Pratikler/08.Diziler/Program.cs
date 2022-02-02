using System;

namespace _08.Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // //Dizi tanımlama
            // string[] renkler = new string[5]; // eleman sayımız belli ama elemanlar bilinmiyor.
            // string[] hayvanlar = {"kedi", "köpek", "kuş","maymun"}; // eleman sayısı ve elemanlar biliniyor.

            // int[] dizi;
            // dizi = new int[5];

            // //Dizilere eleman atama ve erişim
            // renkler[0] = "Mavi";
            // dizi[3] = 10;

            // System.Console.WriteLine(hayvanlar[1]);
            // System.Console.WriteLine(dizi[3]);
            // System.Console.WriteLine(renkler[0]);


            //Döngüler ile dizi kullanımı
            // Ekrandan girilen n tane sayının ortalamasını hesaplama
            System.Console.WriteLine("Dizinin eleman sayısını giriniz: ");
            int diziUzunluğu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunluğu];

            for (int i = 0; i < diziUzunluğu; i++)
            {
                Console.Write("Lütfen {0}. elemanı giriniz: ", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }

            decimal ortalama = Convert.ToDecimal(toplam) / Convert.ToDecimal(diziUzunluğu);
            System.Console.WriteLine("Ortalama: " + ortalama);
        }
    }
}

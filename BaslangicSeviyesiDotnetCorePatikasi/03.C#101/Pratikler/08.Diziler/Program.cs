using System;

namespace _08.Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi tanımlama
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


            // Döngüler ile dizi kullanımı
            // Ekrandan girilen n tane sayının ortalamasını hesaplama
            // System.Console.WriteLine("Dizinin eleman sayısını giriniz: ");
            // int diziUzunluğu = int.Parse(Console.ReadLine());
            // int[] sayiDizisi = new int[diziUzunluğu];

            // for (int i = 0; i < diziUzunluğu; i++)
            // {
            //     Console.Write("Lütfen {0}. elemanı giriniz: ", i + 1);
            //     sayiDizisi[i] = int.Parse(Console.ReadLine());
            // }

            // int toplam = 0;
            // foreach (var sayi in sayiDizisi)
            // {
            //     toplam += sayi;
            // }

            // decimal ortalama = Convert.ToDecimal(toplam) / Convert.ToDecimal(diziUzunluğu);
            // System.Console.WriteLine("Ortalama: " + ortalama);


            // Sort
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };
            System.Console.WriteLine("--SIRASIZ--");
            foreach (var sayi in sayiDizisi)
            {
                System.Console.Write(sayi + " ");
            }

            Array.Sort(sayiDizisi);
            System.Console.WriteLine("\n--SIRALI--");
            foreach (var sayi in sayiDizisi)
            {
                System.Console.Write(sayi + " ");
            }

            // Clear
            System.Console.WriteLine("\n--Array Clear--");
            Array.Clear(sayiDizisi, 2, 4);  //sayiDizisi içerisinde, 2. index ile birlikte 4 elemana 0 yerleştir.
            foreach (var sayi in sayiDizisi)
            {
                System.Console.Write(sayi + " ");
            }

            // Reverse
            System.Console.WriteLine("\n--Reverse--");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                System.Console.Write(sayi + " ");
            }

            // IndexOf
            System.Console.WriteLine("\n--IndexOf--");
            System.Console.WriteLine("İndex: " + Array.IndexOf(sayiDizisi, 72));

            // Resize
            System.Console.WriteLine("--Resize--");
            int oncekiSize = sayiDizisi.Length;
            Array.Resize<int>(ref sayiDizisi, 15);
            int sonrakiSize = sayiDizisi.Length;
            System.Console.WriteLine("Onceki: {0} - Sonraki: {1}", oncekiSize, sonrakiSize);

        }
    }
}

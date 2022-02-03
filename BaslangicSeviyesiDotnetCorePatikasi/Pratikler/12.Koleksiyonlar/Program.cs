using System;
using System.Collections.Generic;

namespace _12.Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            // Count
            System.Console.WriteLine(renkListesi.Count); // 5 
            System.Console.WriteLine(sayiListesi.Count); // 6
            System.Console.WriteLine("---------");

            // Elemanları ekrana yazdırmak Foreach ve List.ForEach
            foreach (var item in renkListesi)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("---------");
            foreach (var item in sayiListesi)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("---------");
            sayiListesi.ForEach(sayi => System.Console.WriteLine(sayi));
            System.Console.WriteLine("---------");
            renkListesi.ForEach(renk => System.Console.WriteLine(renk));
            System.Console.WriteLine("---------");

            // Listeden eleman çıkartma
            sayiListesi.Remove(4);
            renkListesi.Remove("Mavi");
            renkListesi.ForEach(renk => System.Console.WriteLine(renk));
            sayiListesi.ForEach(sayi => System.Console.WriteLine(sayi));
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(0);
            renkListesi.ForEach(renk => System.Console.WriteLine(renk));
            sayiListesi.ForEach(sayi => System.Console.WriteLine(sayi));
            System.Console.WriteLine("---------");

            // Liste içerisinde arama
            if(sayiListesi.Contains(20)){
                System.Console.WriteLine("Eleman bulundu");
            }

            // Diziyi Listeye çevirme
            string[] hayvanlar =  {"kedi", "köpek","kuş"};
            List<string> hayvanlarListesi = new List<string>(hayvanlar);

            // Listeyi temizleme
            hayvanlarListesi.Clear();

            // Liste içerisinde nesne tutmak
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
            Kullanicilar kullanici1 = new Kullanicilar();
            Kullanicilar kullanici2 = new Kullanicilar();
            Kullanicilar kullanici3 = new Kullanicilar();
            kullanici1.Isim = "Ahmet";
            kullanici1.Soyisim = "Sezgin";
            kullanici1.Yas = 22;

            kullanici2.Isim = "Osman";
            kullanici2.Soyisim = "Sezgin";
            kullanici2.Yas = 21;

            kullanici3.Isim = "Ali";
            kullanici3.Soyisim = "Veli";
            kullanici3.Yas = 25;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);
            kullaniciListesi.Add(kullanici3);

            kullaniciListesi.Add(new Kullanicilar{
                Isim = "Emre",
                Soyisim = "Bulut",
                Yas = 19
            });

            foreach (var item in kullaniciListesi)
            {
                System.Console.WriteLine("Ad: {0}, Soyad: {1}, Yas: {2}",item.Isim,item.Soyisim,item.Yas);
            }


        }
    }

    public class Kullanicilar {
        string isim;
        string soyisim;
        int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}

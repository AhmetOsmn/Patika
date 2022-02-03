using System;
using System.Collections;
using System.Collections.Generic;

namespace _12.Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // KoleksiyonlarDers2();
            // KoleksiyonlarDers3();

            // Dictionary
            // Keyler unique olmalıdır.
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
            kullanicilar.Add(10, "Ahmet Sezgin");
            kullanicilar.Add(20, "Osman Sezgin");
            kullanicilar.Add(30, "Ali Veli");

            // Elemanlara Erişim
            System.Console.WriteLine("----------Elemanlara Erişim------------");
            foreach (var kullanici in kullanicilar)
            {
                System.Console.WriteLine(kullanici); // [10, Ahmet Sezgin], [20, Osman Sezgin], [30, Ali Veli]
            }
            System.Console.WriteLine("-------------");
            // Count
            System.Console.WriteLine(kullanicilar.Count); // 3
            System.Console.WriteLine("-------------");

            // Contains
            System.Console.WriteLine(kullanicilar.ContainsKey(20)); // True
            System.Console.WriteLine(kullanicilar.ContainsValue("Ali Sezgin")); // False
            System.Console.WriteLine("-------------");

            // Remove
            kullanicilar.Remove(10); // Key ile silme
            foreach (var kullanici in kullanicilar)
            {
                System.Console.WriteLine(kullanici); // [20, Osman Sezgin], [30, Ali Veli]
            }
            System.Console.WriteLine("-------------");

            // Keys - Values
            System.Console.WriteLine("keys");
            foreach (var kullanici in kullanicilar)
            {
                System.Console.WriteLine(kullanici.Key); // 
            }

            System.Console.WriteLine("values");
            foreach (var kullanici in kullanicilar){
                System.Console.WriteLine(kullanici.Value);
            }
        }

        static void KoleksiyonlarDers2()
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
            if (sayiListesi.Contains(20))
            {
                System.Console.WriteLine("Eleman bulundu");
            }

            // Diziyi Listeye çevirme
            string[] hayvanlar = { "kedi", "köpek", "kuş" };
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

            kullaniciListesi.Add(new Kullanicilar
            {
                Isim = "Emre",
                Soyisim = "Bulut",
                Yas = 19
            });

            foreach (var item in kullaniciListesi)
            {
                System.Console.WriteLine("Ad: {0}, Soyad: {1}, Yas: {2}", item.Isim, item.Soyisim, item.Yas);
            }
        }

        static void KoleksiyonlarDers3()
        {

            // ArrayList
            // Farklı türde elemanları tutabiliyor.
            ArrayList lst = new ArrayList();
            lst.Add("Ahmet");
            lst.Add(2);
            lst.Add(true);
            lst.Add('a');

            foreach (var item in lst)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("-------------");

            // AddRange - Birden fazla eleman eklemek
            string[] renkler = { "Sarı", "Kırmızı", "Mavi" };
            List<int> sayilar = new List<int>() { 1, 8, 3, 7, 92, 5 };
            lst.AddRange(renkler);
            lst.AddRange(sayilar);
            foreach (var item in lst)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("-------------");

            // Sort - Sıralama yaparken farklı türdeki elemanlar olabileceği için sıralama biraz sıkıntılıdır.
            // lst.Sort();

            // Reverse
            lst.Reverse();
            foreach (var item in lst)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("-------------");

            // Clear
            lst.Clear();
            foreach (var item in lst)
            {
                System.Console.WriteLine(item);
            }
        }
    }

    public class Kullanicilar
    {
        string isim;
        string soyisim;
        int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}

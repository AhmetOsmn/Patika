using System;

namespace _14.SinifKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sınıf kavramı
            // SiniflarDers1();

            // Kurucu metotlar 
            // SiniflarDers2();

            // Encapsulation
            // SiniflarDers3();

            // Static sınıf ve üyeler
            System.Console.WriteLine("Müşteri sayısı: " + Musteri.MusteriSayisi);

            Musteri musteri1 = new Musteri("Ahmet", "SEZGİN", "12345");
            System.Console.WriteLine("Müşteri sayısı: " + Musteri.MusteriSayisi);

            // Statik bir sınıfın içerisinde statik olmayan herhangi bir öğre kullanamayız.
            // Statik sınıflarda kalıtım kullanılamaz.
            // Islemler islemler = new Islemler(); // Hata veriyor. Çünkü statik sınıfların öğelerine 'SınıfAdı.' şeklinde ulaşırız.
            System.Console.WriteLine(Islemler.Topla(100, 500));
            System.Console.WriteLine(Islemler.Cikar(100, 500));
        

        }

        static void SiniflarDers1()
        {
            // Class
            // Metotlardan ve prop'lardan oluşur.

            // Erişim belirleyiciler
            // - Public: Her yerden erişilebilir.
            // - Private: Sadece tanımlandığı sınıf içerisinden erişilebilir. 
            // - Internal: Sadece tanımlandığı proje içerisinden erişilebilir.
            // - Protected: Sadece tanımlandığı sınıfta veya o sınıftan miras alan sınıflardan erişilebilir.

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ahmet";
            calisan1.Soyad = "SEZGİN";
            calisan1.No = 12345678;
            calisan1.Departman = "Backend Developer";
            calisan1.CalisanBilgileri();
            System.Console.WriteLine("----------");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Osman";
            calisan2.Soyad = "SEZGİN";
            calisan2.No = 98765432;
            calisan2.Departman = "Frontend Developer";
            calisan2.CalisanBilgileri();
        }

        static void SiniflarDers2()
        {
            Calisan calisan3 = new Calisan("Ayşe", "Kara", 14725836, "İnsan Kaynakları");
            calisan3.CalisanBilgileri();
            System.Console.WriteLine("-------");
            Calisan calisan4 = new Calisan("Veli", "Tutuk");
            calisan4.CalisanBilgileri(); // "Veli" "Tutuk" "0" ""
        }

        static void SiniflarDers3()
        {
            Ogrenci ogrenci1 = new Ogrenci("Ayşe", "YILMAZ", 001, 3);
            ogrenci1.OgrenciBilgileriniGetir();
            ogrenci1.SinifArttir();
            ogrenci1.OgrenciBilgileriniGetir();
            System.Console.WriteLine("------------");

            Ogrenci ogrenci2 = new Ogrenci("Ahmet", "SEZGİN", 002, 2);
            ogrenci2.OgrenciBilgileriniGetir();
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriniGetir();
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriniGetir();
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriniGetir();
        }
    }

    class Calisan
    {

        public Calisan(string ad, string soyad, int no, string departman)
        {

            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public Calisan()
        {

        }


        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            System.Console.WriteLine("Çalışanın adı: {0}", Ad);
            System.Console.WriteLine("Çalışanın soyadı: {0}", Soyad);
            System.Console.WriteLine("Çalışanın numarası: {0}", No);
            System.Console.WriteLine("Çalışanın departmanı: {0}", Departman);
        }
    }

    class Ogrenci
    {

        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.ogrenciNo = ogrenciNo;
            this.sinif = sinif;
        }

        public Ogrenci()
        {

        }

        public int Sinif
        {
            get => sinif;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir.");
                    sinif = 1;
                }
                else
                {
                    sinif = value;
                }
            }
        }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string Isim { get => isim; set => isim = value; }

        public void OgrenciBilgileriniGetir()
        {
            System.Console.WriteLine("----OGRENCİ BİLGİLERİ");
            System.Console.WriteLine("Öğrencinin adı: " + this.isim);
            System.Console.WriteLine("Öğrencinin soyisim: " + this.soyisim);
            System.Console.WriteLine("Öğrencinin sınıfı: " + this.sinif);
            System.Console.WriteLine("Öğrencinin öğrenci numarası: " + this.ogrenciNo);
        }

        public void SinifArttir()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }
    }

    class Musteri
    {
        private static int musteriSayisi;   // Her zaman değiştirilen son değerini göreceğiz.
        private string Isim;
        private string Soyisim;
        private string TC;

        public Musteri(string isim, string soyisim, string tc)
        {
            Isim = isim;
            Soyisim = soyisim;
            TC = tc;
            musteriSayisi++;
        }

        static Musteri()
        {
            musteriSayisi = 0;
        }

        public static int MusteriSayisi { get => musteriSayisi; set => musteriSayisi = value; }
    }

    static class Islemler
    {
        public static long Topla(int s1, int s2)
        {
            return s1 + s2;
        }

        public static long Cikar(int s1, int s2)
        {
            return s1 - s2;
        }
    }
}

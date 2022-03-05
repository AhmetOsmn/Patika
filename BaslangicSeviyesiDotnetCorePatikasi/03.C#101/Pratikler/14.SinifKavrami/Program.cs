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

            //Encapsulation
            SiniflarDers3();

            // Static sınıf ve üyeleri
            // SiniflarDers4();

            // Struct
            // SiniflarDers5();

            //Enum
            // Sıralı olan sabit verilerde çokça kullanılır. 
            // Günler, aylar vb.
            // System.Console.WriteLine(Gunler.Cuma); // Cuma
            // System.Console.WriteLine((int)Gunler.Cuma); // 5

            // System.Console.Write("Sıcaklık derecesini girin: ");
            // int sicaklik = int.Parse(Console.ReadLine());
            // if(sicaklik <= (int)HavaDurumuEnum.normal){
            //     System.Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim");
            // }
            // else if(sicaklik >= (int)HavaDurumuEnum.sicak){
            //     System.Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
            // }
            // else if(sicaklik >= (int)HavaDurumuEnum.normal && sicaklik < (int)HavaDurumuEnum.cokSicak){
            //     System.Console.WriteLine("Hadi dışarıya çıkalım");
            // }
        }

        static void SiniflarDers1()
        {
            // Class
            // Metotlardan ve prop'lardan oluşur.
            // Sınıflar referans tipindedir.

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

        static void SiniflarDers4()
        {
            System.Console.WriteLine("Müşteri sayısı: " + Musteri.MusteriSayisi);

            Musteri musteri1 = new Musteri("Ahmet", "SEZGİN", "12345");
            System.Console.WriteLine("Müşteri sayısı: " + Musteri.MusteriSayisi);

            // Statik bir sınıfın içerisinde statik olmayan herhangi bir öğre kullanamayız.
            // Statik sınıflarda kalıtım kullanılamaz.
            // Islemler islemler = new Islemler(); // Hata veriyor. Çünkü statik sınıfların öğelerine 'SınıfAdı.' şeklinde ulaşırız.
            System.Console.WriteLine(Islemler.Topla(100, 500));
            System.Console.WriteLine(Islemler.Cikar(100, 500));
        }

        static void SiniflarDers5()
        {
            DikdortgenClass dikdortgen1 = new DikdortgenClass();
            dikdortgen1.KisaKenar = 3;
            dikdortgen1.UzunKenar = 5;
            System.Console.WriteLine("Dikdörtgenin alanı: " + dikdortgen1.AlanHesapla());

            DikdortgenStruct dikdortgen2 = new DikdortgenStruct();
            dikdortgen2.KisaKenar = 3;
            dikdortgen2.UzunKenar = 5;
            System.Console.WriteLine("Dikdörtgenin alanı: " + dikdortgen2.AlanHesapla());

            // Classlar ile farkı olarak new yapmadan da kullanılabilir.
            // Ayrıca Struct'larda parametresiz yapıcı metot yazmamıza izin verilmez. Parametreli yapıcı metot yazabiliriz.
            DikdortgenStruct dikdortgen3; // Bu şekilde kullanıldığında ctor'ile atama yapılamadığı için aşağıdaki gibi atamalar yapılmalıdır.
            dikdortgen3.KisaKenar = 3;
            dikdortgen3.UzunKenar = 5;
            System.Console.WriteLine("Dikdörtgenin alanı: " + dikdortgen3.AlanHesapla());
        }
    }

}

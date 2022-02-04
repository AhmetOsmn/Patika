using System;

namespace _14.SinifKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            // SiniflarDers1();

            Calisan calisan3 = new Calisan("Ayşe", "Kara",14725836,"İnsan Kaynakları");
            calisan3.CalisanBilgileri();

            Calisan calisan4 = new Calisan("Veli","Tutuk");
            calisan4.CalisanBilgileri(); // "Veli" "Tutuk" "0" ""

        }

        static void SiniflarDers1(){
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
    }

    class Calisan {

        public Calisan(string ad, string soyad, int no, string departman){

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

        public void CalisanBilgileri(){
            System.Console.WriteLine("Çalışanın adı: {0}",Ad);
            System.Console.WriteLine("Çalışanın soyadı: {0}",Soyad);
            System.Console.WriteLine("Çalışanın numarası: {0}",No);
            System.Console.WriteLine("Çalışanın departmanı: {0}",Departman);
        }
    }
}

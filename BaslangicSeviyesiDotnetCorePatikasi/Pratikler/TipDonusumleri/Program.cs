using System;

namespace TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion (Bilinçsiz Dönüşüm)
            // Düşük kapasiteli bir değişken kendisinden daha kapasiteli değişkene otomatik olarak dönüşmesidir.
            System.Console.WriteLine("------ IMPLICIT ------");
            byte a = 5;
            sbyte b = 30;
            short c  =10;

            int d = a+b+c;
            System.Console.WriteLine("d: " + d);

            long h = d;
            System.Console.WriteLine("h: " + h);

            float i = h;
            System.Console.WriteLine("i: " + i);

            string e = "Ahmet";
            char f = 'k';
            object o = e+f+d;
            System.Console.WriteLine("o: " + o);



            // Explicit Conversion (Bilinçli Dönüşüm)
            // C#'ın kendi kendine yapamayacağı dönüşümlerdir. Burada Parse ve Convert kullanarak bizlerin dönüşüm yapması gerekir.
            System.Console.WriteLine("------ EXPLICIT ------");
            int x = 4;
            
            byte y = (byte)x;
            System.Console.WriteLine("y: " + y);

            float w = 10.3f;
            byte v = (byte)w;
            System.Console.WriteLine("v: " + v); // Çıktısı: 10, yuvarlama yaptı.
            
            
            
            // ToString
            System.Console.WriteLine("------ TOSTRING ------");
            int xx = 6;

            string yy = xx.ToString();
            System.Console.WriteLine("yy: " + yy);

            string zz = 12.5f.ToString();
            System.Console.WriteLine("zz: " + zz);



            // System.Convert
            System.Console.WriteLine("------ CONVERT ------");
            string s1 = "10", s2 = "25";
            int sayi1, sayi2, toplam;
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            System.Console.WriteLine("Toplam: " + toplam);


            // Parse
            System.Console.WriteLine("------ PARSE ------");
            string m1 = "10";
            string m2 = "10,25";
            int s11;
            double d1;

            s11 = Int32.Parse(m1); // Parse sadece string ifadeleri dönüştürmek içn kullanılır.
            d1 = Double.Parse(m2);

            System.Console.WriteLine("s11: " + s11);
            System.Console.WriteLine("d1: " + d1);

        }
    }
}

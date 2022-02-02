using System;

namespace _09.Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Metotlar metotlar = new Metotlar();

            // Metotlar1();

            // out parametreler
            string sayi = "999";
            int outSayi;

            bool sonuc = int.TryParse(sayi, out outSayi);

            if (sonuc)
            {
                System.Console.WriteLine("Başarılı!");
                System.Console.WriteLine(outSayi);
            }
            else
            {
                System.Console.WriteLine();
            }

            metotlar.Topla(2, 3, out int toplamSonuc);
            System.Console.WriteLine(toplamSonuc);

            //Metot aşırı yükleme - Overloading
            int ifade = 123;
            metotlar.EkranaYazdir(ifade.ToString());
            metotlar.EkranaYazdir(ifade);

        }



        static void Metotlar1(Metotlar metotlar)
        {
            // erisim_belirteci geri_donus_tipi metot_adı(parametre_listesi){
            //     komutlar
            //     return;
            // }
            int a = 2;
            int b = 3;
            System.Console.WriteLine("Klasik: " + (a + b));
            System.Console.WriteLine("Topla: " + metotlar.Topla(a, b));

            metotlar.EkranaYazdir((a + b).ToString());
            System.Console.WriteLine("klasik -- a: {0}, b: {1}, toplam: {2}", a, b, a + b);

            System.Console.WriteLine("metot --a: {0}, b: {1}, toplam: {2}", a, b, metotlar.ArttirVeTopla(a, b));
            System.Console.WriteLine("a: {0}, b: {1}", a, b);

            System.Console.WriteLine("metot --a: {0}, b: {1}, toplam: {2}", a, b, metotlar.ArttirVeTopla2(ref a, ref b));
            System.Console.WriteLine("a: {0}, b: {1}", a, b);
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }

        public void EkranaYazdir(string veri)
        {
            System.Console.WriteLine("EkranaYazdir: " + veri);
        }

        public void EkranaYazdir(int veri)
        {
            System.Console.WriteLine("EkranaYazdir2: " + veri);
        }

        public int ArttirVeTopla(int deger1, int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }

        public int ArttirVeTopla2(ref int deger1, ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }
}

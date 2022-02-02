using System;

namespace _09.Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // erisim_belirteci geri_donus_tipi metot_adı(parametre_listesi){
            //     komutlar
            //     return;
            // }
            int a = 2;
            int b = 3;
            System.Console.WriteLine("Klasik: " + (a + b));
            System.Console.WriteLine("Topla: " + Topla(a, b));

            Metotlar metotlar = new Metotlar();
            metotlar.EkranaYazdir((a + b).ToString());
            System.Console.WriteLine("klasik -- a: {0}, b: {1}, toplam: {2}", a, b, a + b);

            System.Console.WriteLine("metot --a: {0}, b: {1}, toplam: {2}", a, b, metotlar.ArttirVeTopla(a, b));
            System.Console.WriteLine("a: {0}, b: {1}", a, b);

            System.Console.WriteLine("metot --a: {0}, b: {1}, toplam: {2}", a, b, metotlar.ArttirVeTopla2(ref a, ref b));
            System.Console.WriteLine("a: {0}, b: {1}", a, b);

        }

        static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            System.Console.WriteLine("EkranaYazdir: " + veri);
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

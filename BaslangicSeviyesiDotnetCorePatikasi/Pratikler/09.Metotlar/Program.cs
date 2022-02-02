using System;

namespace _09.Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Metotlar metotlar = new Metotlar();

            // Metotlar1(metotlar);
            // Metotlar2(metotlar);

            // Rekürsif - öz yinelemeli
            
            // 3^4
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result = result*3;
            }
            System.Console.WriteLine("3^4: " + result);
            System.Console.WriteLine("Expo: " + metotlar.Expo(3,3));

            //Extension Metotlar
            string ifade = "Ahmet Osman Sezgin";
            bool sonuc = ifade.CheckSpaces();
            System.Console.WriteLine("bosluk var mı: " + sonuc);

            if(sonuc){
                System.Console.WriteLine(ifade.RemoveWhiteSpaces());
                System.Console.WriteLine(ifade.MakeUpperCase());
            }

            int[] dizi = {5,67,23,3,99,7,40};
            dizi.SortArray();
            dizi.IntDiziyiEkranaYazdir();

            string deneme = "ahmetosmansezgin";
            System.Console.WriteLine("İlk karakter: " + deneme.GetFirstChar());
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

        static void Metotlar2(Metotlar metotlar)
        {
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
    
        public int Expo(int sayi, int us){
            if(us<2){
                return sayi;
            }
            return Expo(sayi,us-1) * sayi;
        }
    }

    public static class Extension{
        public static bool CheckSpaces(this string param){
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param){
            string[] dizi = param.Split(" ");

            return string.Join("",dizi);
        }

        public static string MakeUpperCase(this string param){
            return param.ToUpper();
        }

        public static int[] SortArray(this int[] arr){
            Array.Sort(arr);
            return arr;
        }

        public static void IntDiziyiEkranaYazdir(this int[] arr){
            string elements = "";
            foreach (var item in arr)
            {   
                elements += item + " ";
            }
            System.Console.WriteLine(elements);
        }

        public static string GetFirstChar(this string param){
            return param.Substring(0,1);
        }
    }
}

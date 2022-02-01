using System;

namespace _05.HataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Compiletime Hatalar
            // Kodu yazarken derleyicinin bize verdiği hatalar. Burada sözdizim hataları yapılmış demektir.

            // Runtime Hatalar
            // Kodu yazarken farkedemeyebiliriz. Bu tip hataları iyi şekilde kontrol edemezsek programımız kırılacaktır.

            try
            {
                System.Console.WriteLine("Bir sayı giriniz: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Girilen sayı: " + sayi1);
            }
            catch (Exception exc) 
            {
                System.Console.WriteLine("Hata: " + exc.Message.ToString());
            }
            finally{
                System.Console.WriteLine("Hata alınsın veya alınmasın bu mesaj gösterilecektir.");
            }
            System.Console.WriteLine("\n-------------------------------------------------------------\n");
            try
            {
                // int a = int.Parse(null);
                // int a = int.Parse("test");
                int a = int.Parse("2000000000000");
            }
            catch (ArgumentNullException exc)
            {
                System.Console.WriteLine("Boş değer girdiniz");
                System.Console.WriteLine(exc);
            }
            catch (FormatException exc)
            {
                System.Console.WriteLine("Girilen veri tipi uygun değil");
                System.Console.WriteLine(exc.Message);
            }
            catch (OverflowException exc)
            {
                System.Console.WriteLine("Girilen değer çok küçük yada çok büyük");
                System.Console.WriteLine(exc.Message);
            }

        }
    }
}

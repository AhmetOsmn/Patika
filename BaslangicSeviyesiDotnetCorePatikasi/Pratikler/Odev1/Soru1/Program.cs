using System;

namespace Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen dizi boyutunu girin (n): ");
            int size = int.Parse(Console.ReadLine());
            int[] sayilar = new int[size];
            if(size > 0){
                for (int i = 0; i < size; i++)
                {
                    System.Console.Write("Sayi giriniz: ");
                    sayilar[i] = int.Parse(Console.ReadLine());
                }
            }
            else {
                System.Console.WriteLine("Geçersiz dizi boyutu girdiniz. Boyut pozitif olmalı");
            }

            string result = "";

            foreach (var item in sayilar)
            {
                if(item % 2 == 0){
                    result += item + " ";
                }
            }
            System.Console.WriteLine("Girilen çift sayılar: " + result);
        }
    }
}

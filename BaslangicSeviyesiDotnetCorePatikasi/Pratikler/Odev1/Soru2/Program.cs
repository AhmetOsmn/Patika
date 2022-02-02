using System;

namespace Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pozitif 2 sayı giriniz (n) ve (m)");
            string nm = Console.ReadLine();
            string[] sayilar = nm.Split(" ");
            int n = int.Parse(sayilar[0]);
            int m = int.Parse(sayilar[1]);
            
            int[] sayiDizisi = new int[n];
            for (int i = 0; i < n; i++)
            {
                System.Console.Write("{0} tane sayıdan {1}. sayıyı giriniz: ",sayilar[0],i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            string result = "";
            
            foreach (var item in sayiDizisi)
            {
                if(item == m || item%m ==0){
                    result += item + " ";
                }
            }

            System.Console.WriteLine("Girilen sayılardan {0} olan veya {0} ile tam bölünen sayılar: {1}",m,result);

        }
    }
}

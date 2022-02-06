using System;

namespace Soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pozitif bir tam sayı girin (n): ");
            int n = int.Parse(Console.ReadLine());

            string[] kelimeler = new string[n];

            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine("{0} kelimeden {1}. kelimeyi giriniz: ",n,i+1);
                kelimeler[i] = Console.ReadLine();
            }

            Array.Reverse(kelimeler);
            System.Console.WriteLine("Girilen kelimeler sondan başa doğru:");
            foreach (var item in kelimeler)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}

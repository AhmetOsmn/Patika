using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] sesliHarfler = {'a','e','ı','i','o','ö','u','ü'};
            List<char> cumledekiSesliHarfler = new List<char>();

            System.Console.Write("Bir cümle giriniz: ");
            string cumle = Console.ReadLine();

            foreach (var harf in cumle)
            {
                if(Array.IndexOf(sesliHarfler,harf) != -1){
                    cumledekiSesliHarfler.Add(harf);
                }
            }

            string harfler = "";
            foreach (var item in cumledekiSesliHarfler)
            {
                harfler += item + " ";
            }
            System.Console.WriteLine("Cümledeki sesli harfler: " + harfler);

        }
    }
}

using System;

namespace _11.HazirMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp. Hoşgeldiniz";
            string degisken2 = "Dersimiz CSharp. hoşgeldiniz";
            System.Console.WriteLine("degisken: " + degisken); // degisken: Dersimiz CSharp. Hoşgeldiniz

            // Length
            System.Console.WriteLine("Length: " + degisken.Length); // Length: 28

            // ToUpper ToLower
            System.Console.WriteLine("ToUpper: " + degisken.ToUpper()); // ToUpper: DERSİMİZ CSHARP. HOŞGELDİNİZ
            System.Console.WriteLine("ToLower: " + degisken.ToLower()); // ToLower: dersimiz csharp. hoşgeldiniz

            // Concat
            System.Console.WriteLine("Concat: " + string.Concat(degisken, " Konu Hazır Metotlar")); // Concat: Dersimiz CSharp. Hoşgeldiniz Konu Hazır Metotlar

            // Compare, CompareTo
            System.Console.WriteLine("CompareTo: " + degisken.CompareTo(degisken2)); // 0,1,-1 CompareTo: 1
            System.Console.WriteLine("Compare +: " + string.Compare(degisken, degisken2, true)); // 0,1,-1 Compare +: 0
            System.Console.WriteLine("Compare -: " + string.Compare(degisken, degisken2, false)); // 0,1,-1 Compare -: 1

            // Contains
            System.Console.WriteLine("Contains: " + degisken.Contains("CSharp")); // Contains: True

            // EndsWith - StartsWith
            System.Console.WriteLine("Endswith: " + degisken.EndsWith("Hoşgeldiniz")); // Endswith: True
            System.Console.WriteLine("Endswith: " + degisken.StartsWith("CSharp")); // Endswith: False

            // IndexOf - LastIndexOf
            System.Console.WriteLine("IndexOf: " + degisken.IndexOf("CSharp")); // IndexOf: 9
            System.Console.WriteLine("IndexOf: " + degisken.IndexOf("ahmet")); // IndexOf: -1
            System.Console.WriteLine("LastIndexOf: " + degisken.LastIndexOf("i")); // LastIndexOf: 26

            // Insert
            System.Console.WriteLine("Insert: " + degisken.Insert(0, "Merhaba ")); // Insert: Merhaba Dersimiz CSharp. Hoşgeldiniz

            // PadLeft - PadRight
            System.Console.WriteLine("PadLeft: " + degisken + degisken2.PadLeft(40)); //PadLeft: Dersimiz CSharp. Hoşgeldiniz            Dersimiz CSharp. hoşgeldiniz
            System.Console.WriteLine("PadRight: " + degisken.PadRight(40) + degisken2); // PadRight: Dersimiz CSharp. Hoşgeldiniz            Dersimiz CSharp. hoşgeldiniz

            // Remove
            System.Console.WriteLine("Remove: " + degisken.Remove(10)); // Remove: Dersimiz C
            System.Console.WriteLine("Remove: " + degisken.Remove(5,3)); // Remove: Dersi CSharp. Hoşgeldiniz
            System.Console.WriteLine("Remove: " + degisken.Remove(0,1)); // Remove: ersimiz CSharp. Hoşgeldiniz

            //Replace
            System.Console.WriteLine("Replace: " + degisken.Replace("CSharp","C#")); //Replace: Dersimiz C#. Hoşgeldiniz

            // Split
            System.Console.WriteLine("Split: " + degisken.Split(' ')[1]); //Split: CSharp.

            // Substring
            System.Console.WriteLine("Substring: " + degisken.Substring(4)); // Substring: imiz CSharp. Hoşgeldiniz
            System.Console.WriteLine("Substring: " + degisken.Substring(4,16)); //Substring: imiz CSharp. Hoş
        }
    }
}

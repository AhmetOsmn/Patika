using System;

namespace _11.HazirMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // StringHazirMetotlar();
            //DateTimeHazirMetotlar();

            // Math
            System.Console.WriteLine(Math.Abs(-25)); // 25

            System.Console.WriteLine(Math.Sin(10)); // -0,5440211108893698
            System.Console.WriteLine(Math.Cos(10)); // -0,8390715290764524
            System.Console.WriteLine(Math.Tan(10)); // 0,6483608274590866

            System.Console.WriteLine(Math.Ceiling(22.3)); // 23 - Her zaman yukarıya yuvarlar
            System.Console.WriteLine(Math.Round(22.3)); //22 - Yakın olana yuvarlar
            System.Console.WriteLine(Math.Round(22.7)); // 23 - Yakın olana yuvarlar
            System.Console.WriteLine(Math.Floor(22.3)); // 22 - Her zaman asagiya yuvarlar

            System.Console.WriteLine(Math.Min(2,6)); // 2
            System.Console.WriteLine(Math.Max(2,6)); // 6

            System.Console.WriteLine(Math.Pow(3,4)); // 81
            System.Console.WriteLine(Math.Sqrt(81)); // 9
            System.Console.WriteLine(Math.Log(9)); // 2,1972245773362196 - 9'un e tabanındaki logaritmik karşılığı
            System.Console.WriteLine(Math.Exp(3)); // 20,085536923187668 - e üzeri 3'ü verir
            System.Console.WriteLine(Math.Log10(10)); // 1 - 10'un logaritma 10 tabanındaki karşılığı


        }

        static void DateTimeHazirMetotlar()
        {
            System.Console.WriteLine(DateTime.Now); // 2.02.2022 22:20:17
            DateTime time = DateTime.Now;
            System.Console.WriteLine(time.Date); // 2.02.2022 00:00:00
            System.Console.WriteLine(time.Day); // 2
            System.Console.WriteLine(time.Month); // 2
            System.Console.WriteLine(time.Year); // 2022
            System.Console.WriteLine(time.Hour); // 22
            System.Console.WriteLine(time.Minute); // 20
            System.Console.WriteLine(time.Second); // 17
            System.Console.WriteLine("--------");
            System.Console.WriteLine(time.DayOfWeek); // Wednesday
            System.Console.WriteLine(time.DayOfYear); // 33
            System.Console.WriteLine("--------");
            System.Console.WriteLine(time.ToLongDateString()); // 2 Şubat 2022 Çarşamba
            System.Console.WriteLine(time.ToShortDateString()); // 2.02.2022
            System.Console.WriteLine(time.ToLongTimeString()); // 22:20:17
            System.Console.WriteLine(time.ToShortTimeString()); // 22:20
            System.Console.WriteLine("--------");
            System.Console.WriteLine(time.AddDays(20)); // 22.02.2022 22:20:17
            System.Console.WriteLine(time.AddHours(5)); // 3.02.2022 03:20:17
            System.Console.WriteLine(time.AddSeconds(300)); // 2.02.2022 22:25:17
            System.Console.WriteLine(time.AddMonths(5)); // 2.07.2022 22:20:17
            System.Console.WriteLine(time.AddYears(10)); // 2.02.2032 22:20:17
            System.Console.WriteLine(time.AddMilliseconds(100)); // 2.02.2022 22:20:17
            System.Console.WriteLine("--------");
            // DateTime format
            System.Console.WriteLine(time.ToString("dd")); // 02
            System.Console.WriteLine(time.ToString("ddd")); // Çar
            System.Console.WriteLine(time.ToString("dddd")); // Çarşamba

            System.Console.WriteLine(time.ToString("MM")); // 02
            System.Console.WriteLine(time.ToString("MMM")); // Şub
            System.Console.WriteLine(time.ToString("MMMM")); // Şubat

            System.Console.WriteLine(time.ToString("yy")); // 22
            System.Console.WriteLine(time.ToString("yyyy")); // 2022
        }
        static void StringHazirMetotlar()
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
            System.Console.WriteLine("Remove: " + degisken.Remove(5, 3)); // Remove: Dersi CSharp. Hoşgeldiniz
            System.Console.WriteLine("Remove: " + degisken.Remove(0, 1)); // Remove: ersimiz CSharp. Hoşgeldiniz

            //Replace
            System.Console.WriteLine("Replace: " + degisken.Replace("CSharp", "C#")); //Replace: Dersimiz C#. Hoşgeldiniz

            // Split
            System.Console.WriteLine("Split: " + degisken.Split(' ')[1]); //Split: CSharp.

            // Substring
            System.Console.WriteLine("Substring: " + degisken.Substring(4)); // Substring: imiz CSharp. Hoşgeldiniz
            System.Console.WriteLine("Substring: " + degisken.Substring(4, 16)); //Substring: imiz CSharp. Hoş
        }
    }
}

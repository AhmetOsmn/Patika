using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            // byte b = 1; // bellekte 1 byte yer kaplar.
            // sbyte c = 1; // 1 byte

            // short s = 2; // 2 byte
            // ushort us = 2; //2 byte

            // Int16 i16 = 2; // 2 byte
            // int i = 4; // 4 byte
            // Int32 i32 = 4; // 4byte
            // uint ui = 4; // 4 byte
            // Int64 i64 = 8; // 8 byte

            // long l = 8; // 8 byte
            // ulong ul = 8; // 8byte

            // //reel sayılar için kullanılırlar
            // float f = 4; // 4 byte 
            // double d = 8; //8 byte 
            // decimal de = 16; // 16 byte 

            // char ch = '2'; // 2 byte
            // string str = "ahmet"; // sınırsız

            // bool b1 = true;
            // bool b2 = false;

            DateTime dt = DateTime.Now;
            System.Console.WriteLine(dt);

            // tüm veri türleri bir object olduğundan, Object nesnesi her türlü veriyi tutabilir.
            object o1 = "ahmet";
            object o2 = 'b';
            object o3 = 2;
            object o4 = 4.5;

            // string ifadeler
            string str1 = String.Empty;
            str1 = "Ahmet Osman Sezgin";
            string ad = "ahmet osman";
            string soyad = "sezgin";
            string adSoyad = ad + " " + soyad;

            // integer tanımlama şekilleri
            int i1 = 5;
            int i2 = 2;
            int i3 = i1 * i2;

            // boolean
            // bool bool1 = 10 > 2; //true

            //Değişken dönüşümleri
            string str20 = "20";
            int i20 = 20;
            string yeniDeger = str20 + i20.ToString();
            System.Console.WriteLine("yeni deger: " + yeniDeger); // Çıktısı: 2020

            int i40 = i20 + Convert.ToInt32(str20);
            System.Console.WriteLine("toplam = " + i40); // Çıktısı: 40

            int i41 = i20 + int.Parse(str20);
            System.Console.WriteLine(i41); // Çıktısı: 40

            //datetime
            string dt2 = DateTime.Now.ToString("dd.MM.yyyy");
            string dt3 = DateTime.Now.ToString("dd'/'MM'/'yyyy");
            string dt4 = DateTime.Now.ToString("HH:mm");
            System.Console.WriteLine(dt2 + "--" + dt3 + "--" + dt4); // Çıktısı: 01.02.2022--01/02/2022--21:14

        }
    }
}

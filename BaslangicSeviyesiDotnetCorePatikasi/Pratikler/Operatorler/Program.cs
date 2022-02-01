using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve işlemli atama
            int x = 3;
            int y = 3;

            System.Console.WriteLine("\n---İşlemli Atama---");
            y = y + 2;
            System.Console.WriteLine(y);
            
            y += 2;
            System.Console.WriteLine(y);

            y /= 1;
            System.Console.WriteLine(y);
            
            y *= 2;
            System.Console.WriteLine(x);


            // Mantıksal operatörler
            // ||, &&, !
            bool isSuccess = true;  
            bool isComplited = false;
            System.Console.WriteLine("\n---Mantıksal Operatorler---");
            if (isSuccess && isComplited)
                System.Console.WriteLine("Perfect!");

            if(isSuccess || isComplited)
                System.Console.WriteLine("Great!");  

            if(isSuccess || !isComplited)
                System.Console.WriteLine("Fine!");  


            // İlişkisel operatörler
            // <, >, <=, >=, ==, !=
            int a = 3;
            int b = 4;
            System.Console.WriteLine("\n---İlişkisel Operatorler---");
            System.Console.WriteLine(a<b);
            System.Console.WriteLine(a>b);
            System.Console.WriteLine(a>=b);
            System.Console.WriteLine(a<=b);
            System.Console.WriteLine(a==b);
            System.Console.WriteLine(a!=b);


            // Aritmatik operatörler
            // /,*,+,-,%
            int sayi1 = 10;
            int sayi2 = 20;
            int sayi3 = 3;
            System.Console.WriteLine("\n---Aritmetik Operatorler---");
            System.Console.WriteLine(sayi1/sayi2);
            System.Console.WriteLine(sayi1*sayi2);
            System.Console.WriteLine(sayi1+sayi2);
            System.Console.WriteLine(sayi1-sayi2);
            System.Console.WriteLine(sayi2%sayi3);

        }
    }
}

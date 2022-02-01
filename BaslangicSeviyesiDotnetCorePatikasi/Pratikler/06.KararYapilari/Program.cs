using System;

namespace _06.KararYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time >= 6 && time < 11)
            {
                System.Console.WriteLine("Günaydın");
            }
            else if (time <= 18)
            {
                System.Console.WriteLine("İyi günler");
            }
            else
            {
                System.Console.WriteLine("İyi geceler");
            }

            string sonuc = time <= 18 ? "İyi günler" : "İyi geceler";
            string sonuc2 = time >= 6 && time < 11 ? "Günaydın" : time <= 18 ? "İyi Günler" : "İyi Geceler";
            System.Console.WriteLine("-----------IF-ELSE-----------");
            System.Console.WriteLine("Sonuc1: " + sonuc);
            System.Console.WriteLine("Sonuc2: " + sonuc2);

            int month = DateTime.Now.Month;
            System.Console.WriteLine("-----------SWITCH-CASE-----------");
            switch(month)
            {
                case 12:
                case 1:
                case 2:
                    System.Console.WriteLine("Kış");
                    break;
    
                case 3:       
                case 4:
                case 5:
                    System.Console.WriteLine("İlkbahar");
                    break;
                
                case 6:               
                case 7:               
                case 8:
                    System.Console.WriteLine("Yaz");
                    break;
               
                case 9: 
                case 10:
                case 11:
                    System.Console.WriteLine("Sonbahar");
                    break;

                default:
                break;
            }
        }
    }
}

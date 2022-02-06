using System;

namespace _15.OOP
{
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            System.Console.WriteLine("Veritabanına yazıldı");
        }
    }
}
using System;

namespace _15.OOP
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            System.Console.WriteLine("Dosyaya yazıldı..");
        }
    }
}
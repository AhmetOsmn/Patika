using System;

namespace _15.OOP
{
    public class SmsLogger : ILogger
    {
        public void WriteLog()
        {
            System.Console.WriteLine("Sms gönderildi..");
        }
    }
}
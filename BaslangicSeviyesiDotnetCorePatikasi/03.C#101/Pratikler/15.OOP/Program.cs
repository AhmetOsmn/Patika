using System;

namespace _15.OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inheritance
            // InheritanceDersi();

            // Polymorphism (çok biçimlilik) ve Sealed Class
            PolymorphismDersi();

            // Interface
            // InterfaceDersi1();
            // InterfaceDersi2();

            // Abstract Sınıflar
            //AbstractDersi();
        }

        static void InheritanceDersi()
        {
            // Bir sınıfın başka bir sınıftan miras almasını temsil eder.

            System.Console.WriteLine("tohumlu1:");
            TohumluBitkiler tohumlu1 = new TohumluBitkiler();
            tohumlu1.TohumlaCogalma();
            System.Console.WriteLine("----------------------------");
            System.Console.WriteLine("marti:");
            Kuslar marti = new Kuslar();
            marti.Ucmak();
        }

        static void PolymorphismDersi()
        {
            // Çok biçimlilik bize base sınıftaki metotların alt sınıflarda farklı şekilde kullanılmasını sağlar.
            // Örnek olarak UyaranlaraTepki metodunu martı ve tohumlu1 nesnesi farklı şekilde kullanıyor.
            // Bir metotdu alt sınıflarda farklı bir şekilde kullanmak istersek base class'ta virtual keyi ile metodu işaretleriz.
            // Alt sınıfta işaretlenen metodu ezebilmek için metoda override keyini ekleyerek metodu farklı bir şekilde kullanabiliriz.
            // Eğer bir class'ın kalıtım vermesini engellemek istersek sınıfı tanımlarken Sealed keyi ile tanımlarsak bunu sağlamış oluruz.

            System.Console.WriteLine("tohumlu1:");
            TohumluBitkiler tohumlu1 = new TohumluBitkiler();
            System.Console.WriteLine("----------------------------");
            System.Console.WriteLine("marti:");
            Kuslar marti = new Kuslar();
        }

        static void InterfaceDersi1()
        {
            // Interface'ler sınıfların içermesi gereken metotların imzalarının yer aldığı bir taslaktır.
            // Burada yazılan imzalardan kasıt metotların gövdelerinin yazılmamasıdır. 

            FileLogger fileLogger = new FileLogger();
            DatabaseLogger databaseLogger = new DatabaseLogger();
            SmsLogger smsLogger = new SmsLogger();

            fileLogger.WriteLog();
            databaseLogger.WriteLog();
            smsLogger.WriteLog();

            LogManager logManager = new LogManager(new FileLogger());
            logManager.WriteLog();
        }

        static void InterfaceDersi2()
        {
            Focus focus = new Focus();
            System.Console.WriteLine(focus.Marka().ToString());
            System.Console.WriteLine(focus.standartRenk().ToString());
            System.Console.WriteLine(focus.TekerlekSayisi().ToString());
            System.Console.WriteLine("-------------------");

            Corolla corolla = new Corolla();
            System.Console.WriteLine(corolla.Marka().ToString());
            System.Console.WriteLine(corolla.standartRenk().ToString());
            System.Console.WriteLine(corolla.TekerlekSayisi().ToString());
        }

        static void AbstractDersi()
        {
            // Sadece kalıtım için kullanılan sınıflardır.
            // Normal sınıflar gibi new ile türetilemezler.
            // Gövdesini yazmadan metot bildirimi yapabiliriz.
            // Abstract metotlar override edilebilir.
            // Yani abstract bir sınıf içerisindeki bir metodu abstract olarak işaretlersek, bu sınıftan türetilen sınıflar bu abstract metodu kullanmak zorundadır.
            NewFocus newFocus = new NewFocus();
            System.Console.WriteLine(newFocus.Marka().ToString());
            System.Console.WriteLine(newFocus.standartRenk().ToString());
            System.Console.WriteLine(newFocus.TekerlekSayisi().ToString());
            System.Console.WriteLine("-------------------");

            NewCorolla newCorolla = new NewCorolla();
            System.Console.WriteLine(newCorolla.Marka().ToString());
            System.Console.WriteLine(newCorolla.standartRenk().ToString());
            System.Console.WriteLine(newCorolla.TekerlekSayisi().ToString());
        }
    }
}

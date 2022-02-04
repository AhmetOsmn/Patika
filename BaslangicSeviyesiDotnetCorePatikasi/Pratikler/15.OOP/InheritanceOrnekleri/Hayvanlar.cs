using System;

namespace _15.OOP
{
    public class Hayvanlar : Canlilar
    {
        protected void Adaptasyon()
        {
            System.Console.WriteLine("Hayvanlar adaptasyon gerçekleştirebilir.");
        }

        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            System.Console.WriteLine("Hayvanlar temasa tepki verir");
        }
    }

    public class Surungenler : Hayvanlar
    {
        public Surungenler()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void Surunmek()
        {
            System.Console.WriteLine("Sürüngenler sürünerek hareket eder.");
        }
    }
    public class Kuslar : Hayvanlar
    {
        public Kuslar()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
        }
        public void Ucmak()
        {
            System.Console.WriteLine("Kuşlar uçarak hareket eder.");
        }
    }
}

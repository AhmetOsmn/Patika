using System;

namespace _15.OOP
{
    public class Corolla : IOtomobil
    {
        public Markalar Marka()
        {
            return Markalar.Toyota;
        }

        public Renkler standartRenk()
        {
            return Renkler.Beyaz;
        }

        public int TekerlekSayisi()
        {
            return 4;
        }
    }
}
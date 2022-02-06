using System;

namespace _15.OOP
{
    public class Civic : IOtomobil
    {
        public Markalar Marka()
        {
            return Markalar.Honda;
        }

        public Renkler standartRenk()
        {
            return Renkler.Gri;
        }

        public int TekerlekSayisi()
        {
            return 4;
        }
    }
}
using System;

namespace _15.OOP
{
    public class Focus : IOtomobil
    {
        public Markalar Marka()
        {
           return Markalar.Ford;
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
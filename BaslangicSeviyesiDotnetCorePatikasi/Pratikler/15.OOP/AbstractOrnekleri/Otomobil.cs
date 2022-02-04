using System;

namespace _15.OOP
{
    public abstract class Otomobil
    {
        public int TekerlekSayisi()
        {
            return 4;
        }
        public abstract Markalar Marka();
        public virtual Renkler standartRenk()
        {
            return Renkler.Beyaz;
        }
    }
}
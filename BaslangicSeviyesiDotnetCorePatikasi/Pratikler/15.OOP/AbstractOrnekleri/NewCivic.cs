using System;

namespace _15.OOP
{
    public class NewCivic : Otomobil
    {
        public override Markalar Marka()
        {
            return Markalar.Honda;
        }

        public override Renkler standartRenk()
        {
            return Renkler.Gri;
        }
    }
}
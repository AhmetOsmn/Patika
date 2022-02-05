using System;
using System.Collections.Generic;

namespace _17.ToDoUygulamasi
{
    public class KartManager : IKartService
    {

        private List<Kart> _kartListesi;

        public KartManager(List<Kart> karts)
        {
            _kartListesi = karts;
        }

        public void KartDuzenle(Kart kart)
        {
            Kart tempKart = _kartListesi.Find(x => x.ID == kart.ID);
            tempKart = kart;
        }

        public void KartEkle(Kart kart)
        {
            _kartListesi.Add(kart);
            System.Console.WriteLine("Kart eklendi!");
        }

        public void KartiGoster(Kart kart)
        {
            System.Console.Write("Başlık: "+kart.Baslik);
            System.Console.WriteLine("İçerik: "+kart.Icerik);
            System.Console.WriteLine("Atanan Kişi: "+kart.AtananKisi);
            System.Console.WriteLine("Büyüklük: "+kart.Buyukluk);
            System.Console.WriteLine("Büyüklük: "+kart.Buyukluk);
            System.Console.WriteLine("-");
        }

        public void KartSil(Kart kart)
        {
            Kart tempKart = _kartListesi.Find(x => x.ID == kart.ID);
            _kartListesi.Remove(tempKart);
        }
    }
}
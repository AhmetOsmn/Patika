using System;
using System.Collections.Generic;

namespace _17.ToDoUygulamasi
{
    public class BoardManager : BoardService
    {
        private List<Kart> _kartListesi;

        public BoardManager(List<Kart> karts)
        {
            _kartListesi = karts;
        }


        public void KartlariListele()
        {
            foreach (var kart in _kartListesi)
            {
                System.Console.Write("Başlık: " + kart.Baslik);
                System.Console.WriteLine("İçerik: " + kart.Icerik);
                System.Console.WriteLine("Atanan Kişi: " + kart.AtananKisi);
                System.Console.WriteLine("Büyüklük: " + kart.Buyukluk);
                System.Console.WriteLine("-");
            }
        }
    }
}
using System;

namespace _17.ToDoUygulamasi
{
    public interface IKartService
    {

        void KartEkle(Kart kart);
        void KartSil(Kart kart);
        void KartTasi(Kart kart, Lines eski, Lines yeni);
        void KartiGoster(Kart kart);
    }
}
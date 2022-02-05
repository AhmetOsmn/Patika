using System;

namespace _17.ToDoUygulamasi
{
    public interface IKartService
    {

        void KartEkle(Kart kart);
        void KartSil(Kart kart);
        void KartDuzenle(Kart kart);
        void KartiGoster(Kart kart);
    }
}
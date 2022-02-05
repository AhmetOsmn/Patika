using System;

namespace _17.ToDoUygulamasi
{
    public interface BoardService
    {
        void KartlariListele();
        Kart KartlardaAra(string baslikAdi);
    }
}
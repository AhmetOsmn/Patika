using System;

namespace _17.ToDoUygulamasi
{
    public class Kart
    {
        public static int TempID { get; set; }
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string AtananKisi { get; set; }
        public Buyuklukler Buyukluk { get; set; }
        public Lines Line { get; set; }


        static Kart()
        {
            TempID++;
        }

        public Kart(string baslik, string icerik, string atananKisi, Buyuklukler buyukluk, Lines line)
        {
            this.ID = TempID;
            this.Baslik = baslik;
            this.Icerik = icerik;
            this.AtananKisi = atananKisi;
            this.Buyukluk = buyukluk;
            this.Line = line;
        }

        public Kart()
        {

        }
    }
}

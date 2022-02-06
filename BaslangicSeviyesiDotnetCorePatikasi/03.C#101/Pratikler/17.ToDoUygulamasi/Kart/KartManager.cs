using System;
using System.Collections;
using System.Collections.Generic;

namespace _17.ToDoUygulamasi
{
    public class KartManager : IKartService
    {

        private Board _board;

        public KartManager(Board board)
        {
            _board = board;
        }

        public void KartEkle(Kart kart)
        {
            _board.ToDoList.Add(kart);
            System.Console.WriteLine("Kart eklendi!");
        }

        public void KartiGoster(Kart kart)
        {
            System.Console.WriteLine("Başlık: " + kart.Baslik);
            System.Console.WriteLine("İçerik: " + kart.Icerik);
            System.Console.WriteLine("Atanan Kişi: " + kart.AtananKisi);
            System.Console.WriteLine("Büyüklük: " + kart.Buyukluk);
            System.Console.WriteLine("Line: " + kart.Line.ToString());
            System.Console.WriteLine("\n");
        }

        public void KartSil(Kart kart)
        {

            if (kart.Line == Lines.todo)
            {
                _board.ToDoList.Remove(kart);
                System.Console.WriteLine("Kart silindi!");
            }
            else if (kart.Line == Lines.inProgress)
            {
                _board.InprogressList.Remove(kart);
                System.Console.WriteLine("Kart silindi!");

            }
            else
            {
                _board.DoneList.Remove(kart);
                System.Console.WriteLine("Kart silindi!");
            }
        }

        public void KartTasi(Kart kart, Lines eski, Lines yeni)
        {
            if (eski == Lines.done)
            {
                _board.DoneList.Remove(kart);
            }
            else if (eski == Lines.inProgress)
            {
                _board.InprogressList.Remove(kart);
            }
            else
            {
                _board.ToDoList.Remove(kart);
            }

            if (yeni == Lines.done)
            {
                _board.DoneList.Add(kart);
            }
            else if (yeni == Lines.inProgress)
            {
                _board.InprogressList.Add(kart);
            }
            else
            {
                _board.DoneList.Add(kart);
            }

            System.Console.WriteLine("Taşıma işlemi tamamlandı.");
        }
    }
}
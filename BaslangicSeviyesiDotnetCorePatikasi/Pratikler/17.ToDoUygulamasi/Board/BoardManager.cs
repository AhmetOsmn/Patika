using System;
using System.Collections.Generic;

namespace _17.ToDoUygulamasi
{
    public class BoardManager : BoardService
    {
        private Board _board;

        public BoardManager(Board board)
        {
            _board = board;
        }

        public Kart KartlardaAra(string baslikAdi)
        {
            List<Kart> allCards = new List<Kart>();
            foreach (var item in _board.ToDoList)
            {
                allCards.Add(item);
            }
            foreach (var item in _board.InprogressList)
            {
                allCards.Add(item);
            }
            foreach (var item in _board.DoneList)
            {
                allCards.Add(item);
            }

            Kart tempKart = allCards.Find(x => x.Baslik.ToLower() == baslikAdi.ToLower());

            return tempKart;
        }

        public void KartlariListele()
        {
            System.Console.WriteLine("\n");
            System.Console.WriteLine("* TODO Line                         *");
            System.Console.WriteLine("*************************************");
            if (_board.ToDoList.Count == 0)
            {
                System.Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (var kart in _board.ToDoList)
                {
                    System.Console.WriteLine("Başlık: " + kart.Baslik);
                    System.Console.WriteLine("İçerik: " + kart.Icerik);
                    System.Console.WriteLine("Atanan Kişi: " + kart.AtananKisi);
                    System.Console.WriteLine("Büyüklük: " + kart.Buyukluk);
                    System.Console.Write("\n");

                }
            }

            System.Console.Write("\n");

            System.Console.WriteLine("* IN PROGRESS Line                  *");
            System.Console.WriteLine("*************************************");
            if (_board.InprogressList.Count == 0)
            {
                System.Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (var kart in _board.InprogressList)
                {
                    System.Console.WriteLine("Başlık: " + kart.Baslik);
                    System.Console.WriteLine("İçerik: " + kart.Icerik);
                    System.Console.WriteLine("Atanan Kişi: " + kart.AtananKisi);
                    System.Console.WriteLine("Büyüklük: " + kart.Buyukluk);
                    System.Console.Write("\n");
                }
            }

            System.Console.Write("\n");

            System.Console.WriteLine("* DONE Line                         *");
            System.Console.WriteLine("*************************************");
            if (_board.DoneList.Count == 0)
            {
                System.Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (var kart in _board.DoneList)
                {
                    System.Console.WriteLine("Başlık: " + kart.Baslik);
                    System.Console.WriteLine("İçerik: " + kart.Icerik);
                    System.Console.WriteLine("Atanan Kişi: " + kart.AtananKisi);
                    System.Console.WriteLine("Büyüklük: " + kart.Buyukluk);
                    System.Console.Write("\n");
                }
            }

        }
    }
}
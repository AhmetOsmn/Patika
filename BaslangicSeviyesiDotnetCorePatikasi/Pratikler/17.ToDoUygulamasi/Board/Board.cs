using System;
using System.Collections.Generic;

namespace _17.ToDoUygulamasi
{
    public class Board{
        List<Kart> kartlar = new List<Kart>();
        List<Kart> toDoList = new List<Kart>();
        List<Kart> inprogressList = new List<Kart>();
        List<Kart> doneList = new List<Kart>();


        public List<Kart> Kartlar { get => kartlar; set => kartlar = value; }
    }    
}
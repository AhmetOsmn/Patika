using System;
using System.Collections.Generic;

namespace _17.ToDoUygulamasi
{
    public class Board
    {

        List<Kart> toDoList = new List<Kart>();
        List<Kart> inprogressList = new List<Kart>();
        List<Kart> doneList = new List<Kart>();

        public List<Kart> ToDoList { get => toDoList; set => toDoList = value; }
        public List<Kart> InprogressList { get => inprogressList; set => inprogressList = value; }
        public List<Kart> DoneList { get => doneList; set => doneList = value; }
    }
}
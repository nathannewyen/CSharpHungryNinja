using System;
using HungryNinja.Models;

namespace HungryNinja {
    class Program {
        static void Main (string[] args) {
            Buffet Gee = new Buffet ();
            Ninja Eddie = new Ninja (2200);
            while (!Eddie.IsFull) {
                Eddie.Eat (Gee.Serve ());
            }
            Eddie.Eat (Gee.Serve ());
        }
    }
}
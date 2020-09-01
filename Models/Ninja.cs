using System;
using System.Collections.Generic;

namespace HungryNinja.Models {
    public class Ninja {
        private int calorieIntake;
        private int calorieLimit;
        public List<Food> FoodHistory;
        public bool IsFull { get { return calorieIntake >= calorieLimit; } }
        public Ninja (int c) {
            this.calorieIntake = 0;
            this.calorieLimit = c;
            this.FoodHistory = new List<Food> ();
        }
        public void Eat (Food item) {
            Console.WriteLine ($"Ninja Eddie's about to eat {item.Name}");
            if (this.IsFull) {
                Console.WriteLine ("Ninja is full, can't eat anymore.");
            } else {
                this.calorieIntake += item.Calories;
                this.FoodHistory.Add (item);
            }
        }
    }
}
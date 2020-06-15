using System;
using System.Collections.Generic;

namespace HungryNinja.Models
{
    public class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;

        public int CalorieIntake
        {
            get
            {
                return calorieIntake;
            }
        }

        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }

        bool full = true;
        public bool IsFull
        {
            get
            {
                if(calorieIntake < 1200)
                {
                    full = false;
                }
                else
                {
                    full = true;
                }
                return full;
            }
        }

        public void Eat(Food item)
        {
            if(!IsFull)
            {
                calorieIntake = calorieIntake + item.Calories;
                FoodHistory.Add(item);
            }
            else
            {
                Console.WriteLine("This Ninja is full and cannot eat anymore!");
            }

            string flavor;
            if(item.IsSpicy == true)
            {
                flavor = "This dish is spicy";
            }
            else if(item.IsSweet == true)
            {
                flavor = "This dish is sweet";
            }
            else if(item.IsSpicy == true && item.IsSweet == true)
            {
                flavor = "This dish is spicy and sweet";
            }
            else
            {
                flavor = "This dish is bland";
            }

            Console.WriteLine($"The Ninja ate {item.Name}. {flavor}.");
            Console.Write($"So far, the Ninja has eaten ");
            foreach(Food ate in FoodHistory)
            {
                Console.Write(ate.Name + ", ");
            }
            Console.WriteLine($"and consumed a total of ");
            foreach(Food ate in FoodHistory)
            {
                Console.Write(ate.Calories);
            }
            Console.WriteLine($" calories.");
        }
    }
}
using System;
using System.Collections.Generic;

namespace HungryNinja.Models
{
    public class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;

        public Food(string name, int calories, bool spicy, bool sweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }
}
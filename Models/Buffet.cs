using System;
using System.Collections.Generic;

namespace HungryNinja.Models
{
    public class Buffet
    {
        public List<Food> Menu;
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Sausage pizza", 1500, true, false),
                new Food("Pesto chicken", 1300, true, false),
                new Food("Red Velvet cake", 2000, false, true),
                new Food("Nachos", 800, true, false),
                new Food("T-bone steak", 300, false, false),
                new Food("Sweet and Sour chicken", 900, true, true),
                new Food("Escargot", 200, false, false)
            };
        }

        public Food Serve()
        {
            // Swap algorithm
            Random rand = new Random();
            for(int i = 0; i < Menu.Count; i++)
            {
                int randIndex = rand.Next(Menu.Count);
                Food temp = Menu[i];
                Menu[i] = Menu[randIndex];
                Menu[randIndex] = temp;
            }

            Food Entre = Menu[0];
            return Entre;
        }
    }
}
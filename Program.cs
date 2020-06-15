using System;
using HungryNinja.Models;
using System.Collections.Generic;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet selections = new Buffet();
            Ninja firstNinja = new Ninja();
            Food serving = selections.Serve();
            firstNinja.Eat(serving);
        }
    }
}

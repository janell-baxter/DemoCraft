using System;
using System.Collections.Generic;
using System.Text;
using static DemoCraft.Utility;

namespace DemoCraft
{
    public class CraftingStation
    {
        Person Player = new Person();
        public void Start()
        {
            //concatenation
            Print("Welcome " + Player.Name + " to the Crafting Station!");
            
            //composite 
            Console.WriteLine("Welcome {0} to the Crafting Station!", Player.Name);

            //interpolation
            Print($"Welcome {Player.Name} to the Crafting Station!");

            Console.ReadKey();
        }
    }
}
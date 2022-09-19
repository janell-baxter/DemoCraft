using System;
using static System.Console;
namespace DemoCraft
{
    class Program
    {
        static void Main()
        {
            Title = "Crafting Station Pro 2000";
            CraftingStation craftingStation = new CraftingStation();
            craftingStation.Start();
        }
    }
}

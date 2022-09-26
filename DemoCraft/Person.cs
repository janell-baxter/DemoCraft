using System;
using System.Collections.Generic;
using System.Text;
using static DemoCraft.Utility;
using static System.Console;

namespace DemoCraft
{
    public class Person
    {
        private string name = "Anonymous Player";
        private double currency = 30.78;

        public List<Item> Inventory = new List<Item>();
        public Person(){}
    public Person(string _name) {
            name = _name;
        }
        public string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }

        public double Currency
        {
            get => currency;
            set
            {
                currency = value;
            }
        }

        public void ChangeName()
        {
            Print("What would you like your name to be?");
            Name = GetInputFromPlayer();
            Print("Your name has been updated!");
            Pause();
            Clear();
        }

        public string ShowInventory()
        {
            string output = $"Inventory for {name}\n";
            foreach (Item i in Inventory)
            {
                output += i.ShowDescription() + Environment.NewLine;
            }
            return output;
        }
    }
}
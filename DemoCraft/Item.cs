using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCraft
{
    public class Item
    {
        public string Name;
        public double Value = 1.0;
        //public float Cost = 1.0f;
        //public decimal Price = 1.0m;

        public Item(string name, double value)
        {
            Name = name;
            Value = value;
        }

        public Item()
        {

        }

        public string ShowDescription() => $"{Name} ({Value.ToString("c")})";

    }
}
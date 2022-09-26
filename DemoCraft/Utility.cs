using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DemoCraft
{
    class Utility
    {
        public static void Print(string message)
        {
            Console.WriteLine(message);
            //Output.Text += message;
        }

        //public string ConvertTextToLowerCase(string message)
        //{
        //    return message.ToLower();
        //}

        //expression bodied method
        public string ConvertTextToLowerCase(string message) => message.ToLower();

        //expression bodied method
       // public static string GetInputFromPlayer() => Console.ReadLine();

        public static string GetInputFromPlayer()
        {
            return Console.ReadLine();
        }

        public static void Pause()
        {
            Print("Press any key to continue...");
            Console.ReadKey();
        }

        public static int GetItemID(List<Item> list, Item i) => list.IndexOf(i);
        public static bool ItemIsInInventory(List<Item> list, Item i)
        {
            //looks for a matching instance
            if (list.Contains(i))
            {
                //optional - do something
                return true;
            }
            return false;
        }
        public static bool ItemIsInInventory(List<Item> list, string name)
        {
            //possibly easier to read, but not as elegant
            foreach (Item i in list)
            {
                if (i.Name.ToLower() == name.ToLower())
                {
                    //item could also be removed or altered here
                    //example: list.Remove(i);
                    return true;
                }
            }
            return false;
        }

        public static void AddToCollectionByName(List<Item> list, Item itemName)
        {
            list.Add(itemName);
        }
        public static void RemoveFromCollectionByIndexNumber(List<Item> list, int itemIndexNumber)
        {
            list.RemoveAt(itemIndexNumber);
        }

        public static string ReadTextFromExternalFile(string fileName)
        {
            if (File.Exists(fileName))
                return File.ReadAllText(fileName);

            return "Information unavailable at this time";
        }

        public static List<Item> GetInventoryFromExternalFile(string fileName)
        {
            List<Item> inventory = new List<Item>();
            string[] itemNames = File.ReadAllLines(fileName);
            foreach(string name in itemNames)
            {
                inventory.Add(new Item() {Name = name });
            }

            return inventory;
        }
    }
}

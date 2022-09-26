using System;
using System.Collections.Generic;
using System.Text;
using static DemoCraft.Utility;

namespace DemoCraft
{
    public class CraftingStation
    {
        Person Player = new Person();
        Person Merchant = new Person("Merchant");
        public void Start()
        {
            Player.Inventory.Add(new Item("Map", 3.4)); //uses constructor
            Player.Inventory.Add(
                new Item() //object initialization
                {
                    Name = "Statue",
                    Value = 52.10
                }
                );
            //Merchant.Inventory.Add(new Item("Golden Orb", 500.89));  
            Merchant.Inventory = GetInventoryFromExternalFile("../../../data/traderInventory.txt");
     
            //concatenation
            //Print("Welcome " + Player.Name + " to the Crafting Station!");

            //composite 
            //Console.WriteLine("Welcome {0} to the Crafting Station!", Player.Name);

            //interpolation
            Print($"Welcome {Player.Name} to the Crafting Station!");
            Pause();
            Menu();
        }
        private void Menu()
        {
            HUD();
            Print("Choose an option:\n1. See Inventory\n2. Search for Item\n3. Trade\n4. Change Name\n5. Instructions");
            switch(GetInputFromPlayer())
            {
                case "1":
                    ShowInventory();
                    break;
                case "2":
                    Search();
                    break;
                case "3":
                    Trade();
                    break;
                case "4":
                    Player.ChangeName();
                    break;

                case "5":
                    ShowInstructions();
                    break;
                default:
                    Print("Please enter only one of the options listed.");
                    break;
            }
            
            Menu();
        }
        private void ShowInventory()
        {
            Print(Player.ShowInventory());
            Pause();
        }
        private void Search()
        {
            
            Print("Enter the name of an item:");
            if (ItemIsInInventory(Player.Inventory, GetInputFromPlayer()))
                Print("Item is in inventory");
            else
                Print("You do not have that item");
            Pause();
        }
        private void Trade()
        {
            //Show Merchant's inventory
            Print(Merchant.ShowInventory());
            Pause();
        }
        private void ShowInstructions()
        {
            Print(ReadTextFromExternalFile("../../../data/instructions.txt"));
            Pause();
        }
        private void HUD()
        {
            Print($"{Player.Name} | {Player.Currency.ToString("c")}");
        }
    }
}
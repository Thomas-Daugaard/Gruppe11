using System;
using System.Net.Http.Headers;

namespace Bilka
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryFactory inventoryFactory = new Inventory();
            IProductComponent temp = null;
            ConsoleKeyInfo consoleKeyInfo;

            IProductComponent FullInventory = inventoryFactory.Create();

            while (true)
            {
                Console.WriteLine("Bilka");
                Console.WriteLine("(F)ull inventory, (E)lectronics, (C)lothing, C(O)lonial, Total (V)alue, Total (S)tock, (Q)uit");
                consoleKeyInfo = Console.ReadKey(true);

                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.F:
                        Console.Clear();
                        FullInventory.Print();
                        break;
                    case ConsoleKey.E:
                        Console.Clear();
                        FullInventory.FindComponent("Electronics", ref temp);
                        temp.Print();
                        break;
                    case ConsoleKey.C:
                        Console.Clear();
                        FullInventory.FindComponent("Clothing", ref temp);
                        temp.Print();
                        break;
                    case ConsoleKey.O:
                        Console.Clear();
                        FullInventory.FindComponent("Colonial", ref temp);
                        temp.Print();
                        break;
                    case ConsoleKey.V:
                        Console.Clear();
                        Console.WriteLine($"Total inventory value: {FullInventory.GetTotalValue():###,###.00} kr.");
                        break;
                    case ConsoleKey.S:
                        Console.Clear();
                        Console.WriteLine($"(Total inventory stock: {FullInventory.GetTotalStock()} PCS");
                        break;
                    case ConsoleKey.Q:
                        Environment.Exit(1);
                        break;
                }

            }
        }
    }
}

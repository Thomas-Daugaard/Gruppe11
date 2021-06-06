using System;
using System.Globalization;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace Bilka
{
    class Program
    {
        static void Main(string[] args)
        {
            string price;
            string name;
            string stock;

            InventoryFactory inventoryFactory = new Inventory();
            IProductComponent temp = null;
            ConsoleKeyInfo consoleKeyInfo;

            IProductComponent FullInventory = inventoryFactory.Create();

            Printer printerObj = new Printer(FullInventory);

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Bilka");
                Console.WriteLine("(E)lectronics");
                Console.WriteLine("(C)lothing");
                Console.WriteLine("C(O)lonial");
                Console.WriteLine("Total (V)alue");
                Console.WriteLine("Total (S)tock");
                Console.WriteLine("Specific (I)tem");
                Console.WriteLine("Item with (P)rice less than");
                Console.WriteLine("Item with p(R)ice more than");
                Console.WriteLine("Item with S(T)ock less than");
                Console.WriteLine("Item with Stoc(K) more than");
                Console.WriteLine("(Q)uit");
                consoleKeyInfo = Console.ReadKey(true);

                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.F:
                        Console.Clear();
                        printerObj.PrintFullInventory();
                        break;
                    case ConsoleKey.E:
                        Console.Clear();
                        printerObj.PrintWithName("Electronics");
                        break;
                    case ConsoleKey.C:
                        Console.Clear();
                        printerObj.PrintWithName("Clothing");
                        break;
                    case ConsoleKey.O:
                        Console.Clear();
                        printerObj.PrintWithName("Colonial");
                        break;
                    case ConsoleKey.V:
                        Console.Clear();
                        printerObj.PrintTotalValue();
                        break;
                    case ConsoleKey.S:
                        Console.Clear();
                        printerObj.PrintTotalStock();
                        break;
                    case ConsoleKey.I:
                        Console.Clear();
                        Console.WriteLine("Enter product or category you want to print");
                        name = Console.ReadLine();
                        Console.WriteLine("Printing with name: " + name);
                        printerObj.PrintWithName(name);
                        break;
                    case ConsoleKey.P:
                        Console.Clear();
                        Console.WriteLine("Enter Price to get all items with price less than");
                        price = Console.ReadLine();
                        Console.WriteLine("Printing with price less than " + price);
                        printerObj.PrintItemsWithPriceLessThan(Double.Parse(price));
                        break; 
                    case ConsoleKey.R:
                        Console.Clear();
                        Console.WriteLine("Enter Price to get all items with price more than");
                        price = Console.ReadLine();
                        Console.WriteLine("Printing with price more than " + price);
                        printerObj.PrintItemsWithPriceMoreThan(Double.Parse(price));
                        break;
                    case ConsoleKey.T:
                        Console.Clear();
                        Console.WriteLine("Enter stock to get all items with stock less than");
                        stock = Console.ReadLine();
                        Console.WriteLine("Printing with stock less than " + stock);
                        printerObj.PrintItemsWithStockLessThan(Int32.Parse(stock));
                        break;
                    case ConsoleKey.K:
                        Console.Clear();
                        Console.WriteLine("Enter stock to get all items with stock more than");
                        stock = Console.ReadLine();
                        Console.WriteLine("Printing with stock more than " + stock);
                        printerObj.PrintItemsWithStockLargerThan(Int32.Parse(stock));
                        break;
                    case ConsoleKey.Q:
                        Environment.Exit(1);
                        break;

                }

            }
        }
    }
}

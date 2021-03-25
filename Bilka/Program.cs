﻿using System;
using System.Net.Http.Headers;

namespace Bilka
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductCategory fullInventory = new ProductCategory() {Description = "Full inventory of Bilka",Name = "Full Inventory"};
            ProductCategory electronics = new ProductCategory() {Description = "All Electronics",Name = "Electronics"};
            ProductCategory clothing = new ProductCategory() {Description = "All Clothing",Name = "Clothing"};
            ProductCategory kitchen = new ProductCategory() {Description = "All Electronics for the kitchen", Name = "Kitchen Electronics"};
            ProductCategory tv = new ProductCategory() {Description = "All TV",Name = "TV"};
            ProductCategory shirts = new ProductCategory() {Description = "All kinds of Shirts", Name = "Shirts"};

            fullInventory.AddComponent(clothing);
            fullInventory.AddComponent(electronics);
            electronics.AddComponent(kitchen);
            electronics.AddComponent(tv);
            tv.AddComponent(new Product() {Description = "LG Super Slim beautiful 32'' TV", Name = "LG318417", price = 1999});
            tv.AddComponent(new Product() {Description = "LG Super Slim beautiful 32'' TV", Name = "LG318417", price = 1999});
            tv.AddComponent(new Product() {Description = "LG Super Slim beautiful 32'' TV", Name = "LG318417", price = 1999});
            clothing.AddComponent(new Product() {Description = "Cowboy Jeans", Name = "Diesel xx9", price = 495.50});
            clothing.AddComponent(new Product() {Description = "Cowboy Jeans", Name = "Diesel xx9", price = 495.50});
            clothing.AddComponent(new ProductCategory() {Description = "Shirts", Name = "T-Shirts"});
            kitchen.AddComponent(new Product( ) { Description = "Kitchen Appliance", Name = "HomeCooker2000", price = 1200});


            string key;
            do
            {
                Console.WriteLine("Bilka");
                Console.WriteLine("Enter A for full inventory, B for Electronics, C for clothing, E for quit");
                key = Console.ReadLine();

                switch (key)
                {
                    case "A":
                        fullInventory.Print();
                        break;
                    case "B":
                        electronics.Print();
                        break;
                    case "C":
                        clothing.Print();
                        break;
                    case "T":
                        Console.WriteLine(fullInventory.GetTotalValue());
                        break;
                    case "S":
                        Console.WriteLine(fullInventory.GetTotalStock());
                        break;
                    case "F":
                        IProductComponent temp = null;
                        fullInventory.FindComponent("HomeCooker2000", ref temp);
                        if(temp != null)
                            Console.WriteLine(temp.Name);
                        else
                            Console.WriteLine("Product not found");
                        break;
                }

            } while (key != "E");
        }
    }
}

using System;
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
            ProductCategory kitchen = new ProductCategory() {Description = "All Electronics for the kitchen",Name = "Kitchen Electronics"};
            ProductCategory tv = new ProductCategory() {Description = "All TV",Name = "TV"};
            ProductCategory shirts = new ProductCategory() {Description = "All kinds of Shirts", Name = "Shirts"};

            fullInventory.Add(clothing);
            fullInventory.Add(electronics);
            electronics.Add(kitchen);
            electronics.Add(tv);
            tv.Add(new Product() {Description = "LG Super Slim beautiful 32'' TV", Name = "LG318417"});
            tv.Add(new Product() {Description = "LG Super Slim beautiful 32'' TV", Name = "LG318417"});
            tv.Add(new Product() {Description = "LG Super Slim beautiful 32'' TV", Name = "LG318417"});
            clothing.Add(new Product() {Description = "Cowboy Jeans", Name = "Diesel xx9"});
            clothing.Add(new Product() {Description = "Cowboy Jeans", Name = "Diesel xx9"});
            clothing.Add(new ProductCategory() {Description = "Shirts", Name = "T-Shirts"});
            kitchen.Add(new Product() { Description = "Kitchen Appliance", Name = "HomeCooker2000" });


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
                }

            } while (key != "E");



        }
    }
}

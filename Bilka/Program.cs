using System;
using System.Net.Http.Headers;

namespace Bilka
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductCategory FullInventory = new ProductCategory() {Description = "Full inventory of Bilka", Name = "Full Inventory"};
                ProductCategory Clothing = new ProductCategory() { Description = "All Clothing", Name = "Clothing" };
                ProductCategory Colonial = new ProductCategory() { Description = "All Clothing", Name = "Clothing" };
                        ProductCategory  = new ProductCategory() { Description = "All Clothing", Name = "Clothing" };
                        ProductCategory clothing = new ProductCategory() { Description = "All Clothing", Name = "Clothing" };
                ProductCategory Electronics = new ProductCategory() {Description = "All Electronics", Name = "Electronics"};
                    ProductCategory Laptops = new ProductCategory() { Description = "Laptop computers", Name = "Laptops" };
                        ProductCategory Gaming = new ProductCategory() {Description = "Gaming ready high-end laptops", Name = "Gaming"};
                        ProductCategory Coding = new ProductCategory() {Description = "Advanced users computers meant for coding", Name = "Coding"};
                    ProductCategory Mobiles = new ProductCategory() { Description = "Mobile Telephones", Name = "Mobiles" };
            


            
            ProductCategory tv = new ProductCategory() {Description = "All TV",Name = "TV"};


            ProductCategory shirts = new ProductCategory() {Description = "All kinds of Shirts", Name = "Shirts"};

            fullInventory.AddComponent(fullInventory, clothing);
            fullInventory.AddComponent(fullInventory, Electronics);
            Electronics.AddComponent(fullInventory, tv);
            tv.AddComponent(fullInventory, new Product() {Description = "LG Super Slim beautiful 32'' TV", Name = "LG318417", price = 1999});
            tv.AddComponent(fullInventory, new Product() {Description = "LG Super Slim beautiful 32'' TV", Name = "LG318417", price = 1999});
            tv.AddComponent(fullInventory, new Product() {Description = "LG Super Slim beautiful 32'' TV", Name = "LG318417", price = 1999});
            clothing.AddComponent(fullInventory, new Product() {Description = "Cowboy Jeans", Name = "Diesel xx9", price = 495.50});
            clothing.AddComponent(fullInventory, new Product() {Description = "Cowboy Jeans", Name = "Diesel xx9", price = 495.50});
            clothing.AddComponent(fullInventory, new ProductCategory() {Description = "Shirts", Name = "T-Shirts"});
            kitchen.AddComponent(fullInventory, new Product( ) { Description = "Kitchen Appliance", Name = "HomeCooker2000", price = 1200});

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
                        IProductComponent ComptoFind = null;
                        fullInventory.FindComponent("LG318417", ref ComptoFind);
                        if(ComptoFind != null)
                            Console.WriteLine(ComptoFind.Stock);
                        else
                            Console.WriteLine("Product not found");
                        break;
                }

            } while (key != "E");
        }
    }
}

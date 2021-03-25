using System;
using System.Net.Http.Headers;

namespace Bilka
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductComponent temp = null;

            // Create Product categories
            ProductCategory FullInventory = new ProductCategory() {Description = "Full inventory of Bilka", Name = "Full Inventory"};
                ProductCategory Clothing = new ProductCategory() { Description = "All Clothing", Name = "Clothing" };
                ProductCategory Colonial = new ProductCategory() { Description = "All Colonial", Name = "Colonial" };
                    ProductCategory Milk = new ProductCategory() { Description = "Various milk types", Name = "Milk" };
                    ProductCategory Fruit = new ProductCategory() { Description = "Various fruit", Name = "Fruit" };
                ProductCategory Electronics = new ProductCategory() {Description = "All Electronics", Name = "Electronics"};
                    ProductCategory Laptops = new ProductCategory() { Description = "Laptop computers", Name = "Laptops" };
                        ProductCategory Gaming = new ProductCategory() {Description = "Gaming ready high-end laptops", Name = "Gaming"};
                        ProductCategory Coding = new ProductCategory() {Description = "Advanced users computers meant for coding", Name = "Coding"};
                    ProductCategory Mobiles = new ProductCategory() { Description = "Smartphones", Name = "Mobiles" };


            // Construct Category tree
                Colonial.AddComponent(FullInventory, Milk);
                Colonial.AddComponent(FullInventory, Fruit);
            FullInventory.AddComponent(FullInventory, Colonial);
            FullInventory.AddComponent(FullInventory, Clothing);
                Electronics.AddComponent(FullInventory, Mobiles);
                    Laptops.AddComponent(FullInventory, Gaming);
                    Laptops.AddComponent(FullInventory, Coding);
                Electronics.AddComponent(FullInventory,Laptops);
            FullInventory.AddComponent(FullInventory, Electronics);

            // Insert dummy data
            // Electronics data
            Gaming.AddComponent(FullInventory, new Product() {Description = "Asus Gaming PC", Name = "Asus TUF Gaming A15", price = 7999, Stock = 4});
            
            Coding.AddComponent(FullInventory, new Product() {Description = "Dell Linux PC", Name = "Dell XPS 13", price = 21490, Stock = 1});
            Coding.AddComponent(FullInventory, new Product() { Description = "Lenovo Linux PC", Name = "Lenovo ThinkPad T480", price = 5799, Stock = 2 });
            
            Mobiles.AddComponent(FullInventory, new Product() {Description = "iPhone 11, sort, 64 GB", Name = "iPhone 11", price = 3799, Stock = 12});
            Mobiles.AddComponent(FullInventory, new Product() {Description = "Samsung Galaxy S21, sort, 128 GB", Name = "Samsung Galaxy S21", price = 8199, Stock = 9});
            
            // Colonial data
            Milk.AddComponent(FullInventory, new Product() {Description = "Arla whole milk, 1 liter", Name = "Arla whole milk", price = 8.95, Stock = 114});
            Milk.AddComponent(FullInventory, new Product() {Description = "Arla skimmed milk, 1 liter", Name = "Arla skimmed milk", price = 8.95, Stock = 188});

            Fruit.AddComponent(FullInventory, new Product() {Description = "Pineapple", Name = "Pineapple", price = 14, Stock = 75});
            Fruit.AddComponent(FullInventory, new Product() { Description = "Bananas", Name = "Bananas", price = 2, Stock = 500 });
            Fruit.AddComponent(FullInventory, new Product() { Description = "Bananas", Name = "Apples", price = 2, Stock = 198 });

            // Clothing data
            Clothing.AddComponent(FullInventory, new Product() { Description = "T-shirt", Name = "Lupilu baby T-shirt", price = 300, Stock = 7 });
            Clothing.AddComponent(FullInventory, new Product() {Description = "Pink dress", Name = "VRS pink dress", price = 159.50, Stock = 5});


            // Test insertion of multiple similar Products
            Clothing.AddComponent(FullInventory, new Product() {Description = "Cowboy Jeans", Name = "Diesel xx9", price = 495.50});
            Clothing.AddComponent(FullInventory, new Product() {Description = "Cowboy Jeans", Name = "Diesel xx9", price = 495.50});
            Clothing.AddComponent(FullInventory, new Product() { Description = "Cowboy Jeans", Name = "Diesel xx9", price = 495.50 });

            string key;
            do
            {
                Console.WriteLine("Bilka");
                Console.WriteLine("Enter A for full inventory, B for Electronics, C for clothing, E for quit");
                key = Console.ReadLine();

                switch (key)
                {
                    case "A":
                        FullInventory.Print();
                        break;
                    case "B":
                        FullInventory.FindComponent("Electronics", ref temp);
                        temp.Print();
                        break;
                    case "C":
                        Clothing.Print();
                        break;
                    case "T":
                        Console.WriteLine($"{FullInventory.GetTotalValue()} kr.");
                        break;
                    case "S":
                        Console.WriteLine(FullInventory.GetTotalStock());
                        break;
                    case "F":
                        IProductComponent ComptoFind = null;
                        FullInventory.FindComponent("LG318417", ref ComptoFind);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilka
{
    class Inventory : IInventory
    {
        private ProductCategory FullInventory;
        private ProductCategory Clothing;
        private ProductCategory Colonial;
        private ProductCategory Milk;
        private ProductCategory Fruit;
        private ProductCategory Electronics;
        private ProductCategory Laptops;
        private ProductCategory Gaming;
        private ProductCategory Coding;
        private ProductCategory Mobiles;

        public void CreateInventory()
        {
            FullInventory = new ProductCategory() { Description = "Full inventory of Bilka", Name = "Full Inventory" };
            Clothing = new ProductCategory() { Description = "All Clothing", Name = "Clothing" };
            Colonial = new ProductCategory() { Description = "All Colonial", Name = "Colonial" };
            Milk = new ProductCategory() { Description = "Various milk types", Name = "Milk" };
            Fruit = new ProductCategory() { Description = "Various fruit", Name = "Fruit" };
            Electronics = new ProductCategory() { Description = "All Electronics", Name = "Electronics" };
            Laptops = new ProductCategory() { Description = "Laptop computers", Name = "Laptops" };
            Gaming = new ProductCategory() { Description = "Gaming ready high-end laptops", Name = "Gaming" };
            Coding = new ProductCategory() { Description = "Advanced users computers meant for coding", Name = "Coding" };
            Mobiles = new ProductCategory() { Description = "Smartphones", Name = "Mobiles" };

            Colonial.AddComponent(FullInventory, Milk);
            Colonial.AddComponent(FullInventory, Fruit);
            FullInventory.AddComponent(FullInventory, Colonial);
            FullInventory.AddComponent(FullInventory, Clothing);
            Electronics.AddComponent(FullInventory, Mobiles);
            Laptops.AddComponent(FullInventory, Gaming);
            Laptops.AddComponent(FullInventory, Coding);
            Electronics.AddComponent(FullInventory, Laptops);
            FullInventory.AddComponent(FullInventory, Electronics);

            ConcreteInventory = FullInventory;
        }

        public void InsertDummyData()
        {
            Gaming.AddComponent(FullInventory, new Product() { Description = "Asus Gaming PC", Name = "Asus TUF Gaming A15", price = 7999, Stock = 4 });

            Coding.AddComponent(FullInventory, new Product() { Description = "Dell Linux PC", Name = "Dell XPS 13", price = 21490, Stock = 1 });
            Coding.AddComponent(FullInventory, new Product() { Description = "Lenovo Linux PC", Name = "Lenovo ThinkPad T480", price = 5799, Stock = 2 });

            Mobiles.AddComponent(FullInventory, new Product() { Description = "iPhone 11, sort, 64 GB", Name = "iPhone 11", price = 3799, Stock = 12 });
            Mobiles.AddComponent(FullInventory, new Product() { Description = "Samsung Galaxy S21, sort, 128 GB", Name = "Samsung Galaxy S21", price = 8199, Stock = 9 });

            // Colonial data
            Milk.AddComponent(FullInventory, new Product() { Description = "Arla whole milk, 1 liter", Name = "Arla whole milk", price = 8.95, Stock = 114 });
            Milk.AddComponent(FullInventory, new Product() { Description = "Arla skimmed milk, 1 liter", Name = "Arla skimmed milk", price = 8.95, Stock = 188 });

            Fruit.AddComponent(FullInventory, new Product() { Description = "Pineapple", Name = "Pineapple", price = 14, Stock = 75 });
            Fruit.AddComponent(FullInventory, new Product() { Description = "Bananas", Name = "Bananas", price = 2, Stock = 500 });
            Fruit.AddComponent(FullInventory, new Product() { Description = "Apple", Name = "Apples", price = 2, Stock = 198 });

            // Clothing data
            Clothing.AddComponent(FullInventory, new Product() { Description = "T-shirt", Name = "Lupilu baby T-shirt", price = 300, Stock = 7 });
            Clothing.AddComponent(FullInventory, new Product() { Description = "Pink dress", Name = "VRS pink dress", price = 159.50, Stock = 5 });


            // Test insertion of multiple similar Products
            Clothing.AddComponent(FullInventory, new Product() { Description = "Cowboy Jeans", Name = "Diesel xx9", price = 495.50 });
            Clothing.AddComponent(FullInventory, new Product() { Description = "Cowboy Jeans", Name = "Diesel xx9", price = 495.50 });
            Clothing.AddComponent(FullInventory, new Product() { Description = "Cowboy Jeans", Name = "Diesel xx9", price = 495.50 });
        }

        public IProductComponent ConcreteInventory { get; set; }
    }
}

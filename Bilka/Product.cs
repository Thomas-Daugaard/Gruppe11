﻿using System;
using System.Collections.Generic;

namespace Bilka
{
    public class Product : IProductComponent
    {
        public Product()
        {
            Type = IProductComponent.ComponentType.product;
        }
        public Product(string name)
        {
            Name = name;
            Type = IProductComponent.ComponentType.product;
        }
        public void Print()
        {
            Console.WriteLine(Name + "with description: " + Description);
        }
        public double GetTotalValue()
        {
            return price;
        }

        public int GetTotalStock()
        {
            return Stock;
        }
        public IProductComponent FindComponent(string condition)
        {
            return this;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public double price { get; set; }
        public int Stock { get; set; }
        public IProductComponent.ComponentType Type { get; set; }
    }
}
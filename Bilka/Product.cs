using System;
using System.Collections.Generic;

namespace Bilka
{
    public class Product : IProductComponent
    {
        public void Print()
        {
            Console.WriteLine(Name + "with description: " + Description);
        }
        public string Name { get; set; }
        public string Description { get; set; }


    }
}
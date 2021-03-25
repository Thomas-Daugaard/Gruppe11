﻿using System;

namespace Bilka
{
    public interface IProductComponent
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public void Print();
        public double GetTotalValue();
        public int GetTotalStock();
        public int Stock { get; set; }

    }
}
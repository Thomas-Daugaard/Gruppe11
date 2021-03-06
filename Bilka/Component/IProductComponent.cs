using System;
using System.Collections;
using System.Collections.Generic;

namespace Bilka
{
    public interface IProductComponent : IEnumerable<IProductComponent>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public void Print();
        public bool FindComponent(string name, ref IProductComponent component);
        public double GetTotalValue();
        public int GetTotalStock();
        public int Stock { get; set; }
        public double Price { get; set; }

        public enum ComponentType
        {
            productCategory,
            product
        }
        public ComponentType Type { get; set; }
    }
}
using System;

namespace Bilka
{
    public interface IProductComponent
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public void Print();
        public IProductComponent FindComponent(string condition);
        public double GetTotalValue();
        public int GetTotalStock();
        public int Stock { get; set; }

        public enum ComponentType
        {
            productCategory,
            product
        }
        public ComponentType Type { get; set; }
    }
}
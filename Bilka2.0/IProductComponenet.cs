using System;

namespace Bilka
{
    public interface IProductComponent
    {
        public void AddComponent(IProductComponent product);
        public void RemoveComponent(IProductComponent product);
        public IProductComponent GetComponent();
        public void PrintProduct();
        public double GetTotalValue();
        public int NumberOfComponents { get; set; }
        public string Description { get; set; }
    }
}

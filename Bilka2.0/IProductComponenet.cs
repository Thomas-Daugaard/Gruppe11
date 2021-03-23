using System;

namespace Bilka
{
    public interface IProductComponent
    {
        public void AddProduct(IProductComponent p);
        public void RemoveProduct(IProductComponent p);
        public IProductComponent GetProduct();
        public void PrintProduct();
        public double GetTotalValue();
        public int NumberOfComponents { get; set; }
        public string Description { get; set; }
    }
}

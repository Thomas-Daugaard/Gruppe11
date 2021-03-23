using System;

namespace Bilka
{
    public interface IProductComponent
    {
        public void AddProduct(IProductComponent);
        public void RemoveProduct(IProductComponent);
        public IProductComponent GetProduct();
        public void PrintProduct();
        public double GetTotalValue();
        public int NumberOfProducts { get; set; }
        public string Description { get; set; }
    }
}

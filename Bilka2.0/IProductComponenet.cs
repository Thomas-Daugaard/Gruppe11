using System;

namespace Bilka
{
    public interface IProductComponent
    {
        public void AddProduct(Product);
        public void RemoveProduct(Product);
        public Product GetProduct();
        public void PrintProduct();
        public double GetTotalValue();
        public int NumberOfProducts { get; set; }
        public string Description { get; set; }
    }
}

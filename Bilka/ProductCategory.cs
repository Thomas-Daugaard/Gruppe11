using System;
using System.Collections.Generic;

namespace Bilka
{
    public class ProductCategory : IProductComponent
    {
        private List<IProductComponent> _productComponents;

        public ProductCategory()
        {
            _productComponents = new List<IProductComponent>();
        }

        public void AddProduct(IProductComponent productComponent)
        {
            _productComponents.Add(productComponent);
        }

        public void Remove(IProductComponent productComponent)
        {
            _productComponents.Remove(productComponent);
        }

        public void Print()
        {
            Console.WriteLine(Name + " with description: " + Description);

            foreach (var component in _productComponents)
            {
                component.Print();
            }
        }

        public double GetTotalAmount()
        {
            foreach (var productComponent in _productComponents)
            {
                Amount += productComponent.GetTotalAmount();
            }

            return Amount;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }

    }
}
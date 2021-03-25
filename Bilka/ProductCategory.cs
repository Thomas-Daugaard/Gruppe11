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

        public void AddProduct(IProductComponent productLeaf)
        {
            //_productComponents.Contains(productLeaf);
            //for(int i = 0; i<_productComponents.Count;++i)
            //{
            //    if(_productComponents[i].Name == productLeaf.Name)
            //    {
            //        _productComponents[i].Stock += 1;
            //    }
            //    else
            //    {
            //        _productComponents.Add(productLeaf);
            //    }
            //    return;
            //}

            //Set enum type
            _productComponents.Add(productLeaf);
        }

        public void AddCategory(IProductComponent categoryComponent)
        {
            //Set enum type
            _productComponents.Add(categoryComponent);
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

        public int Stock { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }

    }
}
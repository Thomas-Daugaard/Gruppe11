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
            Type = IProductComponent.ComponentType.productCategory;
        }

        public void AddComponent(IProductComponent root, IProductComponent component)
        {

            IProductComponent temp = null;
            bool found = root.FindComponent(component.Name, ref temp);
            if (found)
            {
                if (temp.Type == IProductComponent.ComponentType.product)
                {
                    temp.Stock += component.Stock;
                }
                else if(temp.Type == IProductComponent.ComponentType.productCategory)
                {
                    Console.WriteLine("Category already exists, cannot add again");
                }
            }

            else
                _productComponents.Add(component);
        }

        public bool FindComponent(string name, ref IProductComponent comp)
        {
            foreach (var component in _productComponents)
            {
                if (component.Type == IProductComponent.ComponentType.productCategory && component.Name == name)
                {
                    comp = this;
                    return true;
                }

                else if(component.FindComponent(name, ref comp))
                    return true;
            }
            return false;
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

        public double GetTotalValue()
        {
            Value = 0;

            foreach (var productComponent in _productComponents)
            {
                Value += productComponent.GetTotalValue();
            }

            return Value;
        }

        public int GetTotalStock()
        {
            Stock = 0;
            foreach (var productComponent in _productComponents)
            {
                Stock += productComponent.GetTotalStock();
            }

            return Stock;
        }


        public int Stock { get; set; }
        public IProductComponent.ComponentType Type { get; set; }
        public System.Type TypeOf { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }

        
    }
}
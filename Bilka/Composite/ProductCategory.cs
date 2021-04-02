using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Bilka
{
    public class ProductCategory : IProductComponent
    {
        public List<IProductComponent> ProductComponents;

        public ProductCategory(ProductCategory previousCategory)
        {
            Name = previousCategory.Name;
            Description = previousCategory.Description;
            Value = previousCategory.Value;
            Stock = Stock;
            ProductComponents = previousCategory.ProductComponents;
            Type = previousCategory.Type;
        }

        public ProductCategory()
        {
            ProductComponents = new List<IProductComponent>();
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
                    Debug.WriteLine("Category already exists, cannot add again");
                }
            }

            else
                ProductComponents.Add(component);
        }

        public bool FindComponent(string name, ref IProductComponent comp)
        {
            if (Name == name)
            {
                comp = this;
                return true;
            }

            foreach (var component in ProductComponents)
            {
                if (component.FindComponent(name, ref comp))
                    return true;
            }

            return false;
        }


        public void Remove(IProductComponent productComponent)
        {
            ProductComponents.Remove(productComponent);
        }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine($"********** Category {Name} - consisting of {Description} **********");

            foreach (var component in ProductComponents)
            {
                component.Print();
            }
        }

        public double GetTotalValue()
        {
            Value = 0;

            foreach (var productComponent in ProductComponents)
            {
                Value += productComponent.GetTotalValue();
            }

            return Value;
        }

        public int GetTotalStock()
        {
            Stock = 0;
            foreach (var productComponent in ProductComponents)
            {
                Stock += productComponent.GetTotalStock();
            }

            return Stock;
        }


        public int Stock { get; set; }
        public IProductComponent.ComponentType Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        public double Price { get; set; } = Double.PositiveInfinity;

        // https://stackoverflow.com/questions/39085721/how-to-implement-the-ienumeratort-interface-for-the-composite-pattern
        public IEnumerator<IProductComponent> GetEnumerator()
        {
            var components = new Stack<IProductComponent>(new[] {this});
            while (components.Any())
            {
                IProductComponent component = components.Pop();
                yield return component;
                if (component is ProductCategory category)
                {
                    foreach (var n in category.ProductComponents)
                    {
                        components.Push(n);
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bilka;

namespace Bilka
{
    public class Printer
    {
        private readonly IProductComponent _fullInventory;

        public Printer(IProductComponent fullInventory)
        {
            _fullInventory = fullInventory;
        }
        public void PrintFullInventory()
        {
            _fullInventory.Print();
        }
        public void PrintComponent(IProductComponent component)
        {
            component.Print();
        }

        public void PrintTotalValue()
        {
            Console.WriteLine($"Total inventory value: {_fullInventory.GetTotalValue():###,###.00} kr.");
        }

        public void PrintTotalStock()
        {
            Console.WriteLine($"(Total inventory stock: {_fullInventory.GetTotalStock()} PCS");
        }

        public void PrintWithName(string name)
        {
            foreach (IProductComponent component in _fullInventory)
            {
                try
                {
                    if (component.Name == name)
                    {
                        component.Print();
                    }
                }
                catch (NotSupportedException)
                {
                    Console.WriteLine("Operation not supported");
                }
            }
        }

        public void PrintItemsWithStockLargerThan(int stock)
        {
            foreach (IProductComponent component in _fullInventory)
            {
                try
                {
                    if (component.Stock >= stock && component.Type == IProductComponent.ComponentType.product)
                    {
                        component.Print();
                    }
                }
                catch (NotSupportedException)
                {
                    Console.WriteLine("Operation not supported");
                }
            }
        }

        public void PrintItemsWithStockLessThan(int stock)
        {
            foreach (IProductComponent component in _fullInventory)
            {
                try
                {
                    if (component.Stock < stock && component.Type == IProductComponent.ComponentType.product)
                    {
                        component.Print();
                    }
                }
                catch (NotSupportedException)
                {
                    Console.WriteLine("Operation not supported");
                }
            }
        }

        public void PrintItemsWithPriceLessThan(double price)
        {
            foreach (IProductComponent component in _fullInventory)
            {
                try
                {
                    if (component.Price < price && component.Type == IProductComponent.ComponentType.product)
                    {
                        component.Print();
                    }
                }
                catch (NotSupportedException)
                {
                    Console.WriteLine("Operation not supported");
                }
            }
        }

        public void PrintItemsWithPriceMoreThan(double price)
        {
            foreach (IProductComponent component in _fullInventory)
            {
                try
                {
                    if (component.Price > price && component.Type == IProductComponent.ComponentType.product)
                    {
                        component.Print();
                    }
                }
                catch (NotSupportedException)
                {
                    Console.WriteLine("Operation not supported");
                }
            }
        }
    }
}

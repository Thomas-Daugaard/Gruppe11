﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bilka;

namespace Bilka2._0
{
    public class ProductGroup: IProductComponent
    {
        public void AddProduct(IProductComponent p)
        {
            _children.Add(p);
            ++NumberOfComponents;
        }

        public void RemoveProduct(IProductComponent p)
        {
            int temp = _children.IndexOf(p);
            _children.RemoveAt(temp);
            --NumberOfComponents;
        }
        private List<IProductComponent> _children;
        //public IProductComponent GetProduct()
        //{
        //    throw new NotImplementedException();
        //}

        //public void PrintProduct()
        //{
        //    throw new NotImplementedException();
        //}

        //public double GetTotalValue()
        //{
        //    throw new NotImplementedException();
        //}

        public int NumberOfComponents { get; set; }

        public int NumberOfProducts { get; set; }
        public string Description { get; set; }

    }
}

using Bilka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilka2._0
{
    public class Product : IProductComponent
    {
        public Product( int noOfPro)
        {
            NumberOfProducts = noOfPro;
        }
        public void AddProduct(IProductComponent p)
        {
            return;
        }

        public void RemoveProduct(IProductComponent p)
        {
            return;
        }
        public string Description { get; set; }
        public int NumberOfProducts { get; set; }
    }
}

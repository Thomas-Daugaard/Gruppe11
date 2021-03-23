using System;
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
            throw new NotImplementedException();
        }

        public void RemoveProduct(IProductComponent p)
        {
            throw new NotImplementedException();
        }

        public IProductComponent GetProduct()
        {
            throw new NotImplementedException();
        }

        public void PrintProduct()
        {
            throw new NotImplementedException();
        }

        public double GetTotalValue()
        {
            throw new NotImplementedException();
        }

        public int NumberOfProducts { get; set; }
        public string Description { get; set; }
    }
}

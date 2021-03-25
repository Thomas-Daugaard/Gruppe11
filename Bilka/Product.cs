using System;
using System.Collections.Generic;

namespace Bilka
{
    public class Product : IProductComponent
    {
        public Product()
        {
            _subproductcategories = new List<IProductComponent>();
        }
        public void Print()
        {
            Console.WriteLine(Name + "with description: " + Description);
        }
        public string Name { get; set; }
        public string Description { get; set; }

        public void AddSubCategory(IProductComponent cat)
        {
            _subproductcategories.Add(cat);
        }

        public List<IProductComponent> SubProductategories
        {
            get { return _subproductcategories; }
        }

        private List<IProductComponent> _subproductcategories;
    }
}
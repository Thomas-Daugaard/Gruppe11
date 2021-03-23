using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeLibrary
{
    class Product : IProductComponent
    {
        public void Execute()
        {

        }

        public string Name { get; set; }
        public decimal Price  { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilka
{
    interface IInventory
    {
        public void CreateInventory();
        public void InsertDummyData();
        public IProductComponent ConcreteInventory { get; set; }
    }
}

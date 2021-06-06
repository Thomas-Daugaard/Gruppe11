using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilka
{
    abstract class InventoryFactory
    {
        public abstract IProductComponent Create();
    }
}

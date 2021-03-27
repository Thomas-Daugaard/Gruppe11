using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilka
{
    class InventoryFactory : IInventoryFactory
    {
        private IInventory inventory;

        public InventoryFactory(IInventory inventory)
        {
            this.inventory = inventory;
        }

        public IProductComponent GetInventory()
        {
            inventory.CreateInventory();
            inventory.InsertDummyData();

            return inventory.ConcreteInventory;
        }
    }
}

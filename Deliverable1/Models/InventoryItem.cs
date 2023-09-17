using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable1.Models
{
    public class InventoryItem
    {
        public string name;
        
        public int preferredStock;
        public int inStock;
        public int restockLevel;
        
        public bool reStock;


        public InventoryItem(string ipName, int ipPreferredStock, int ipRestockLevel)
        {
            name = ipName;
            preferredStock = ipPreferredStock;
            inStock = ipPreferredStock;
            restockLevel = ipRestockLevel;
        }

    }

}

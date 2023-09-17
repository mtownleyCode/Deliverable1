namespace Deliverable1.Helpers
{
    internal class Calculations
    {

        public bool CheckRestock(int ipCurrentStock, int ipRestockLevel)
        {
            return ipCurrentStock <= ipRestockLevel;
        }

        public int OrderAmount(int ipCurrentStock, int ipPreferredStock)
        {
            return ipPreferredStock - ipCurrentStock;
        }

        public void CheckStock(int i, Lists inventoryList, int inventorySold)
        {
            inventoryList.inventoryItems[i].inStock = inventoryList.inventoryItems[i].inStock - inventorySold;

            if (CheckRestock(inventoryList.inventoryItems[i].inStock,
                             inventoryList.inventoryItems[i].restockLevel))
            {
                Console.WriteLine($"Current { inventoryList.inventoryItems[i].name } inventory is lower than the restock level, ordering { OrderAmount(inventoryList.inventoryItems[i].inStock, inventoryList.inventoryItems[i].preferredStock) }.");

                inventoryList.inventoryItems[i].inStock += OrderAmount(inventoryList.inventoryItems[i].inStock, inventoryList.inventoryItems[i].preferredStock);

                inventoryList.AddRestockItem(inventoryList.inventoryItems[i].name);
            }

            Console.WriteLine($"The { inventoryList.inventoryItems[i].name } inventory is now {inventoryList.inventoryItems[i].inStock }.");

        }

    }

}

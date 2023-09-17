using Deliverable1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable1.Helpers
{
    public class Lists
    {

        public List<InventoryItem> inventoryItems = new List<InventoryItem>();
        public List<String> restockedItems = new List<String>();


        public void AddInventoryItem(InventoryItem item)
        {
            inventoryItems.Add(item);
        }

        public void AddRestockItem(string name)
        {
            restockedItems.Add(name);
        }

        public void RestockSummary()
        {

            if (restockedItems.Count == 0)
            {
                Console.WriteLine("Thank you for filling out the values. There were no items that needed restocking.");
                StockSummary("The new inventory numbers are...");
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Thank you for filling out the values. These items were automatically restocked:");

                foreach (var item in restockedItems)
                {
                    Console.Write($"{item} ");

                    if (restockedItems.IndexOf(item) == restockedItems.Count - 1)
                    {
                        Console.WriteLine();
                    }

                }

                StockSummary("The new inventory numbers are...");
                Console.WriteLine("Goodbye!");
            }

        }

        public void StockSummary(string message)
        {
            Console.WriteLine();

            Console.WriteLine(message);

            foreach (var inventoryItem in inventoryItems)
            {
                Console.WriteLine($"  {inventoryItem.name} = {inventoryItem.inStock}.");

                if (inventoryItems.IndexOf(inventoryItem) == inventoryItems.Count - 1)
                {
                    Console.WriteLine();
                }
            }

        }

    }

}

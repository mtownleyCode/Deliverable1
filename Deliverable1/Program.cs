using Deliverable1.Models;
using Deliverable1.Helpers;

bool redoLoop;

var sodaInventory = new InventoryItem("Soda", 100, 40);
var chipsInventory = new InventoryItem("Chips", 40, 20);
var candyInventory = new InventoryItem("Candy", 60, 40);
var lists = new Lists();
var amountSold = new AmountSold();


lists.AddInventoryItem(sodaInventory);
lists.AddInventoryItem(chipsInventory);
lists.AddInventoryItem(candyInventory);

Console.WriteLine("Welcome to the restocking tool.");

Console.WriteLine();

lists.StockSummary("The starting inventory numbers are...");

Console.WriteLine();

for (int i = 0; i <= lists.inventoryItems.Count - 1; i++)
{
    if (i > 0) { Console.WriteLine(); }

    amountSold.GetAmountSold(i, lists, out redoLoop);

    if (redoLoop) { i--; }
}

Console.WriteLine();

lists.RestockSummary();

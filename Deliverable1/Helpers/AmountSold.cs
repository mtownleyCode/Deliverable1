namespace Deliverable1.Helpers
{
    public class AmountSold
    {

        public void GetAmountSold(int i, Lists inventoryList, out bool redoLoop)
        {
            var inventorySold = 0;
            var calculations = new Calculations();

            redoLoop = false;

            Console.WriteLine($"Enter the amount of { inventoryList.inventoryItems[i].name } sold today. {inventoryList.inventoryItems[i].inStock} are in stock.");

            if (!int.TryParse(Console.ReadLine(), out inventorySold) ||
                inventorySold <= 0 ||
                inventorySold > inventoryList.inventoryItems[i].inStock)
            {
                if (inventorySold > inventoryList.inventoryItems[i].inStock)
                {
                    Console.WriteLine($"There is not enough stock in { inventoryList.inventoryItems[i].name } for the amount sold. Enter an amount less than the current stock.");
                    redoLoop = true;
                }
                else
                {
                    Console.WriteLine("Enter a valid number greater than 0.");
                    redoLoop = true;
                }

            }

            if (!redoLoop)
            {
                calculations.CheckStock(i, inventoryList, inventorySold);
            }
        }

    }

}

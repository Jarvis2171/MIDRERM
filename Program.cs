using System;

public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        Price = newPrice;
        Console.WriteLine($"{ItemName} price updated to ${newPrice}");
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        QuantityInStock += additionalQuantity;
        Console.WriteLine($"{additionalQuantity} {ItemName}(s) added to stock. New stock quantity: {QuantityInStock}");
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        if (quantitySold > 0)
        {
            if (QuantityInStock >= quantitySold)
            {
                QuantityInStock -= quantitySold;
                Console.WriteLine($"{quantitySold} {ItemName}(s) sold. New stock quantity: {QuantityInStock}");
            }
            else
            {
                Console.WriteLine($"Error: Insufficient stock to sell {quantitySold} {ItemName}(s).");
            }
        }
        else
        {
            Console.WriteLine("Error: Quantity to sell must be greater than zero.");
        }
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        return QuantityInStock > 0;
    }

    // Print item details
    public void PrintDetails()
    {
        Console.WriteLine($"Item: {ItemName}, ID: {ItemId}, Price: ${Price}, Stock Quantity: {QuantityInStock}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // Example tasks:
        // 1. Print details of all items.
        Console.WriteLine("Initial Item Details:");
        item1.PrintDetails();
        item2.PrintDetails();

        // 2. Sell some items and then print the updated details.
        item1.SellItem(3);
        item2.SellItem(5);

        // 3. Restock an item and print the updated details.
        item1.RestockItem(5);

        // 4. Check if an item is in stock and print a message accordingly.
        Console.WriteLine($"Is {item2.ItemName} in stock? {item2.IsInStock()}");

        // Print final details
        Console.WriteLine("Final Item Details:");
        item1.PrintDetails();
        item2.PrintDetails();
    }
}

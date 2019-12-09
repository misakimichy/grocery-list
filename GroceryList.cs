using System;

class GroceryList
{
    static void Main()
    {
        string[] myGroceryList = {"eggs", "milk", "bacons", "bread", "salmon", "sparkling water", "tomatoes"};
        int[] groceryPriceList = {5, 2, 4, 3, 10, 3, 2};
        
        Console.WriteLine("My grocery list:");

        foreach (string item in myGroceryList)
        {
            Console.WriteLine(item);
        }

        int total = 0;
        foreach (int price in groceryPriceList)
        {
            total = total + price;
        }

        Console.WriteLine("Your total price for this shopping will be $" + total + ".");
    }
}
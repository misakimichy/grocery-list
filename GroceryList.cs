using System;

class GroceryList
{
    static void Main()
    {
        string[] myGroceryList = {"eggs", "milk", "bacons", "bread", "salmon", "sparkling water", "tomatoes"};
        int[] groceryPriceList = {5, 2, 4, 3, 10, 3, 2};
        
        Console.WriteLine("My grocery list:");

        for( int i = 0; i < myGroceryList.Length; i++)
        {
            Console.WriteLine(myGroceryList[i]);
        }
        int total = 0;
        foreach (int price in groceryPriceList)
        {
            total = total + price;
        }

        Console.WriteLine("Your total price for this shopping will be $" + total + ".");
    }
}
using System;

class Program
{
    static void Main()
    {
string[] fruits = { "banana", "apple", "orange", "pear", "grape", "pineapple" };
        Console.WriteLine("Please enter the fruit you would like to find: ");
        string searchFruit = Console.ReadLine();
        bool FruitFound = LinearSearch(fruits, searchFruit);
        if (FruitFound)
        {
            Console.WriteLine("your fruit has been found");
        }
        else
        {
            Console.WriteLine("your fruit is not in this list");
        }
    }
    static bool LinearSearch(string[] fruitsArray, string fruitToSearch)
    {
        for (int index = 0; index < fruitsArray.Length; index++)
        {
            if (fruitsArray[index] == fruitToSearch)
            {
                return true; 
            }
        }
        return false;
    }
}

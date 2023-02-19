using System;

class Program
{
    static void Main()
    {
        HashCode wordTable = new HashCode(5);

        // A little bit of hard coding
        wordTable.Insert("Unknown", "The Brave the World");
        wordTable.Insert("C#", "Love it");
        wordTable.Insert("Life", "is good");
        wordTable.Insert("Billions", "great show on HBO");
        wordTable.Insert("Pills", "Do not use em :)");

        wordTable.PrintTable();

        
        Console.WriteLine("Enter a word to search in the hash table:");
        string userInput = Console.ReadLine();

        string result = wordTable.Find(userInput);

        if (result != null)
        {
            Console.WriteLine($"Found value: {result}");
        }
        else if (result == null)
        {
            Console.WriteLine("Sorry... Word not found");
        }
        
        Console.WriteLine(wordTable.LoadFactor());
    }
}
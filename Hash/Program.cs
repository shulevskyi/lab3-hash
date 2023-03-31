using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Initial size of the hash table
        HashCode wordTable = new HashCode(5);
        
        LoadDataFromFile(wordTable, "../../../dictionary.txt");
        
        InsertElementAfterKey(wordTable);
        
        SearchForWord(wordTable);

        // Check load factor and expand the hash table if necessary
        CheckLoadFactorAndExpand(wordTable);
    }

    static void LoadDataFromFile(HashCode wordTable, string filePath)
    {
        Console.WriteLine("Loading data from the file...");

        string[] lines;
        
        using (StreamReader reader = new StreamReader(filePath))
        {
            lines = reader.ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        }
        
        foreach (string line in lines)
        {
            string[] parts = line.Split(';');
            wordTable.Insert(parts[0], parts[1]);
        }

        Console.WriteLine("Data loaded successfully.\n");
    }

    static void InsertElementAfterKey(HashCode wordTable)
    {
        Console.Write("Enter an existing key to insert a new element after: ");
        string existingKey = Console.ReadLine();
        
        Console.Write("Enter a new key: ");
        string newKey = Console.ReadLine();

        Console.Write("Enter a new value: ");
        string newValue = Console.ReadLine();

        wordTable.InsertAfterKey(existingKey, newKey, newValue);

        int listLength = wordTable.GetLinkedListLength(existingKey);
        Console.WriteLine($"\nNew key-value pair '{newKey}-{newValue}' inserted after '{existingKey}'.");
        Console.WriteLine($"The length of the linked list after the insertion is {listLength}.\n");
    }

    static void SearchForWord(HashCode wordTable)
    {
        Console.Write("Enter a word to search in the hash table: ");
        string userInput = Console.ReadLine();

        string result = wordTable.Find(userInput);

        if (result != null)
        {
            Console.WriteLine($"Found value: {result}\n");
        }
        else
        {
            Console.WriteLine("Sorry... Word not found\n");
        }
    }

    static void CheckLoadFactorAndExpand(HashCode wordTable)
    {
        double loadFactor = wordTable.LoadFactor();
        Console.WriteLine($"Current load factor: {loadFactor}");

        if (loadFactor > 0.75)
        {
            wordTable.Expand();
            loadFactor = wordTable.LoadFactor();
            Console.WriteLine($"The hash table has been expanded. New load factor: {loadFactor}\n");
        }
    }
}

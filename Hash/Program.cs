using System;

class Program
{
    static void Main()
    {
        // initial size of the hash table
        HashCode wordTable = new HashCode(5);
        
        // Insert /Users/danielshulevskiy/RiderProjects/Hash/Hash into the hash table

        // Open the file and read its contents
        string[] lines;
        
        using (StreamReader reader = new StreamReader("../../../dictionary.txt"))
        {
            lines = reader.ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        }
        

        // Insert words and definitions into the table
        foreach (string line in lines)
        {
            string[] parts = line.Split(';');
            if (parts.Length == 2)
            {
                wordTable.Insert(parts[0], parts[1]);
                Console.WriteLine(parts[0], parts[1]);
            }
        }
        
        

        
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
        
        wordTable.AutoExpansion();
        
        //Console.WriteLine(wordTable.LoadFactor());
        //wordTable.PrintTable();
    }
}
using System.Collections;

namespace Hash;

public class HashCode

{

    
    
    // Print the table if null then prints index and "-" else prints the index and the value
    
    public void Print(Hashtable wordTable)
    {
        Console.WriteLine("Table:");
        for (int i = 0; i < wordTable.Count; i++)
        {
            if (wordTable[i] == null)
            {
                Console.WriteLine(i + " -- ");
            }
            else
            {
                Console.WriteLine(i + " - " + wordTable[i]);
            }
        }
    }
    
    // boolean functio that inserts the word in the table
    
    public bool Insert(string key, string value, Hashtable wordTable)
    {
        int hash = GetHash(key, wordTable);
        if (wordTable[hash] == null)
        {
            wordTable[hash] = value;
            return true;
        }

        return false;
    }
    
    // lookup function to find the word in the table by key
    
    public string Find(string key, Hashtable wordTable)
    {
        
        int hashkey = GetHash(key, wordTable);
        Console.WriteLine(hashkey);
        if (wordTable[hashkey] != null)
        {
            return wordTable[hashkey].ToString();
        }

        return null;
    }
    
    
    
    // Function GetHash that returns the hashcode of the word
    
    public int GetHash(string key, Hashtable wordTable)
    {
        int hash = 0;
        for (int i = 0; i < key.Length; i++)
        {
            hash += key[i];
        }

        return hash % wordTable.Count;
    }
    
    
    
    

}
using System;

public class HashCode
{
    
    // The size of the hash table
    private readonly int _size;
    
    // An array of linked lists to store pairs (key-value)
    private readonly LinkedList<KeyValuePair<string, string>>[] _table;

    public HashCode(int size)
    {
        _size = size;
        _table = new LinkedList<KeyValuePair<string, string>>[size];
    }

    public void Insert(string key, string value)
    {
        int index = GetHash(key);
        if (_table[index] == null)
        {
            // If null create a new linked list
            _table[index] = new LinkedList<KeyValuePair<string, string>>();
        }
        
        // Add pair to the end of linked list for the index
        _table[index].AddLast(new KeyValuePair<string, string>(key, value));
    }

    public string Find(string key)
    {
        int index = GetHash(key);
        LinkedList<KeyValuePair<string, string>> list = _table[index];
        if (list != null)
        {
            
            // If Collision, search for the key in the linked list (a little bit slower)
            foreach (KeyValuePair<string, string> pair in list)
            {
                if (pair.Key == key)
                {
                    return pair.Value;
                }
            }
        }
        Console.WriteLine("Word not found");
        return null;
    }

    private int GetHash(string key)
    {
        int hash = 0;
        for (int i = 0; i < key.Length; i++)
        {
            hash += key[i];
        }
        return hash % _size;
    }

    public void PrintTable()
    {
        for (int i = 0; i < _size; i++)
        {
            Console.Write($"Index {i}: ");
            LinkedList<KeyValuePair<string, string>> list = _table[i];
            if (list == null)
            {
                Console.WriteLine("-");
            }
            else
            {
                foreach (KeyValuePair<string, string> pair in list)
                {
                    // Make a pointer visible for better understanding
                    Console.Write($"[{pair.Key}, {pair.Value}] -> ");
                }
                Console.WriteLine();
            }
        }
    }
    
    // Load factor
    
    public double LoadFactor() 
    {
         int count = 0;
         for (int i = 0; i < _size; i++)
         {
             LinkedList<KeyValuePair<string, string>> list = _table[i];
             if (_table[i] != null)
             {
                 foreach (KeyValuePair<string, string> pair in list)
                 {

                     count++;
                 }
             }
         }
         return count / _size; 
    }
}
using System;

public class HashCode
{
    
    // The size of the hash table
    private int _size;
    
    // An array of linked lists to store pairs (key-value)
    private LinkedList<KeyValuePair<string, string>>[] _table;

    public HashCode(int size)
    {
        _size = size;
        _table = new LinkedList<KeyValuePair<string, string>>[size];
    }

    public void Insert(string key, string value)
    {
        // Create a new pair
        KeyValuePair<string, string> pair = new KeyValuePair<string, string>(key, value);
        
        // Get the hash of the key
        int index = GetHash(key);
        
        // If the cell is empty, create a new linked list
        if (_table[index] == null)
        {
            _table[index] = new LinkedList<KeyValuePair<string, string>>();
        }
        
        // Insert the pair into the linked list
        _table[index].AddLast(pair);
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
         int nulcount = 0;
         int count = 0;
         for (int i = 0; i < (float)_size; i++)
         {
             LinkedList<KeyValuePair<string, string>> list = _table[i];
             if (_table[i] != null)
             {
                 foreach (KeyValuePair<string, string> pair in list)
                 {
                     count ++;
                 }
             }
             else if (_table[i] == null)
             {
                 nulcount ++; 
             }
         }
         
         //Console.WriteLine(count);
         //Console.WriteLine(nulcount);
         // return float because the result is a decimal number
         return (float)count / _size;

    }
    
    // load factor, count the non-empty buckets and divide by the size of the table 
    
    
    public void AutoExpansion()
    {
        // check if the load factor is greater than or equal to 0.7
        if (LoadFactor() >= 0.7)
        {
            // Create a new hash table with double size
            HashCode newTable = new HashCode(_size * 2);

            // Copy all pairs from the old table to the new one
            for (int i = 0; i < _size; i++)
            {
                LinkedList<KeyValuePair<string, string>> list = _table[i];
                if (list != null)
                {
                    foreach (KeyValuePair<string, string> pair in list)
                    {
                        newTable.Insert(pair.Key, pair.Value);
                    }
                }
            }

            // Replace the old table with the new one
            _table = newTable._table;
            _size = newTable._size;

            //Console.WriteLine("Updated LoadFactor: " + newTable.LoadFactor());
        }
        
        Console.WriteLine(LoadFactor());
    }

}
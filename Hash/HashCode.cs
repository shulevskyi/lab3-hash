using System.Collections;

namespace Hash;

public class HashCode
{
    // get the ASKII from word1.Key
    
    public int GetHash(string key, Hashtable wordTable)
    {
        int hash = 0;
        for (int i = 0; i < key.Length; i++)
        {
            hash += key[i];
            hash *= key[i];
            
            // use module and the size of the table
            hash %= wordTable.Count;
            
        }
        return hash;
    }
    
    
    
    

}
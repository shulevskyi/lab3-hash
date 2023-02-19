using System;
using System.Collections;
using Hash;
using KeyValuePair = Hash.KeyValuePair;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable wordTable = new Hashtable();
            
            KeyValuePair word1 = new KeyValuePair(1, "Automachine");
            KeyValuePair word2 = new KeyValuePair(2, "Drying");
            KeyValuePair word3 = new KeyValuePair(3, "Lyfing");
            KeyValuePair word4 = new KeyValuePair(4, "billlions that what i want");
            KeyValuePair word5 = new KeyValuePair(5, "Modafinil");
    
            wordTable.Add(word1.Value, word1);
            wordTable.Add(word2.Value, word2);
            wordTable.Add(word3.Value, word3);
            wordTable.Add(word4.Value, word4);
            wordTable.Add(word5.Value, word5);


            KeyValuePair storedWord1 = (KeyValuePair)wordTable[word1.Value];
            
            //Console.WriteLine("Word ID: {0}, Definition: {1}", storedWord1.Key, storedWord1.Value);
            //Console.WriteLine("Word ID: {0}, Definition: {1}", KeyValuePair.Pair, storedWord1.Value);
            
            LinkedListNode smth1 = new LinkedListNode(word1);
            
            
            KeyValuePair pair = smth1.Pair;
            int key = pair.Key;
            Console.WriteLine(pair.Key);

        }
    }
}


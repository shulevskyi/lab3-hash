using System;
using System.Collections;
using Hash;
using KeyValuePair = Hash.KeyValuePair;
using HashCode = Hash.HashCode;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable wordTable = new Hashtable();
            
            
            KeyValuePair word1 = new KeyValuePair("Auto", "Automachine");
            KeyValuePair word2 = new KeyValuePair("Dry", "Drying");
            KeyValuePair word3 = new KeyValuePair("Life", "Lyfing");
            KeyValuePair word4 = new KeyValuePair("Billion", "billlions that what i want");
            KeyValuePair word5 = new KeyValuePair("MModa", "Modafinil");
    
            wordTable.Add(word1.Value, word1);
            wordTable.Add(word2.Value, word2);
            wordTable.Add(word3.Value, word3);
            wordTable.Add(word4.Value, word4);
            wordTable.Add(word5.Value, word5);

            HashCode word11 = new HashCode();
            
            Console.WriteLine(word11.GetHash(word4.Key, wordTable));


            //KeyValuePair storedWord1 = (KeyValuePair)wordTable[word1.Value];
            
            //Console.WriteLine("Word ID: {0}, Definition: {1}", storedWord1.Key, storedWord1.Value);
            //Console.WriteLine("Word ID: {0}, Definition: {1}", KeyValuePair.Pair, storedWord1.Value);
            
            //LinkedListNode smth1 = new LinkedListNode(word1.Key, word1.Value);
            
            
            //KeyValuePair<int, string> pair = smth1.Pair;
            //int key = pair.Key;
            //Console.WriteLine(pair.Key);

        }
    }
}


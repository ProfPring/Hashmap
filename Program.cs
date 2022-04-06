using System;
using System.Collections;
using System.Collections.Generic;

namespace HashMap
{
    class Program
    {
        
        static void Main(string[] args)
        {
            HashTable<int, string> myHashmap = new HashTable<int, string>(10);

            myHashmap.Add(0, "Mia");
        }
    }
}

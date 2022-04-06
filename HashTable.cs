using System;
using System.Collections.Generic;

using System.Text;

namespace HashMap
{
    public class HashTable<Tkey, TValue>
    {
        private KeyValuePair<Tkey, TValue>[] KeyValuePairArray;
        public HashTable(int size)
        {
            KeyValuePairArray = new KeyValuePair<Tkey, TValue>[size];
        }

        private int  HashFunction(Tkey key, TValue value)  
        {
            string unnHashedValue = $"{value.ToString()}";
            byte[] ASCIIvalues = Encoding.ASCII.GetBytes(unnHashedValue);

            //add acsii codes togther and divide by the ammount of elements in the array
            int sum = 0;
            foreach(byte ASCIIvalue in ASCIIvalues)
            {
                sum += ASCIIvalue;
            }
            int Result;
            int hashedValue = Math.DivRem( sum, KeyValuePairArray.Length , out Result);
            return Result;
        }
        public void Add(Tkey key, TValue value)
        {
            int hasCode = HashFunction(key, value);
            KeyValuePairArray[hasCode] = new KeyValuePair<Tkey, TValue>(key, value);
        }
    }
}

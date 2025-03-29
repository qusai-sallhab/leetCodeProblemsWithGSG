using System;
using System.Collections.Generic;

namespace RandomizedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RandomizedSet rand = new RandomizedSet();

            Console.WriteLine(rand.Insert(1));
            Console.WriteLine(rand.Insert(1));
            Console.WriteLine(rand.Remove(1));
            Console.WriteLine(rand.Remove(1));
            Console.WriteLine(rand.Remove(2));
            Console.WriteLine(rand.Insert(1));
            Console.WriteLine(rand.Insert(2));
            Console.WriteLine(rand.Insert(3));
            Console.WriteLine(rand.Insert(4));
            Console.WriteLine(rand.Insert(5));
            Console.WriteLine(rand.Insert(6));
            Console.WriteLine(rand.Insert(7));
            Console.WriteLine(rand.Insert(6));
            Console.WriteLine(rand.GetRandom());
        }

        public class RandomizedSet
        {
            Dictionary<int, int> dictionary;
            Random random;
            public RandomizedSet()
            {
                dictionary = new Dictionary<int, int>();
                random = new Random();
            }

            public bool Insert(int val)
            {
                if (dictionary.ContainsKey(val)) return false;
                dictionary.Add(val, 0);
                return true;
            }

            public bool Remove(int val)
            {
                return dictionary.Remove(val);
            }

            public int GetRandom()
            {
                int[] temp=new int[dictionary.Keys.Count];
                dictionary.Keys.CopyTo(temp,0);
                
                return temp[random.Next(0, dictionary.Keys.Count)];
            }
        }





    }


}

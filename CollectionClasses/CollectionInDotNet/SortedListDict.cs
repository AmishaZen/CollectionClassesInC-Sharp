using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionInDotNet
{
    class SortedListDict
    {
        static void Main(string[] args)
        {
            SortedList st = new SortedList();
            st.Add("a", "first");
            st.Add("Z", "Second");
            st.Add("X", "Third");
            st.Add("c", "fourth");
            st.Add("V", "fifth");

            foreach (DictionaryEntry item in st)
            {
                Console.WriteLine($"key is {item.Key} value is {item.Value}");
            }
            Console.WriteLine($"Get value through index {st.GetByIndex(2)}");

            //GetKeyList
            IList il = st.GetKeyList();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Sortedlist Keys are");
            foreach (var item in il)
            {
                Console.WriteLine(item);
            }

            //GetValueList
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Sortedlist values are");
            IList ils = st.GetValueList();
            foreach (var item in ils)
            {
                Console.WriteLine(item);
            }

            
            //Capacity
            Console.WriteLine("-------------------------Capacity---------------------------\n");
            Console.WriteLine($"Capacity of sorted list is {st.Capacity}\n");

            //Count
            Console.WriteLine("-------------------------Count---------------------------\n");
            Console.WriteLine($"Count of sorted list data is {st.Count}\n");

            //ContainsKey
            Console.WriteLine("-------------------------ContainsKey---------------------------\n");
            Console.WriteLine($"Is SortedList contains key \"v\"? {st.ContainsKey("v")}\n");

            //ContainsValue
            Console.WriteLine("-------------------------ContainsValue---------------------------");
            Console.WriteLine($"Is SortedList Contains Values \"Second\" {st.ContainsValue("Second")}\n");

            //IndexOfKey
            Console.WriteLine("-------------------------IndexOfKey---------------------------\n");
            Console.WriteLine($"Index of key \"a\" is = {st.IndexOfKey("a")}\n"); //wrong key gives restu in -1

            //IndexOfValue
             Console.WriteLine("-------------------------IndexOfValue---------------------------");
            Console.WriteLine($"Index of VAlue is = {st.IndexOfValue("Second")}\n");

            //GetByIndex
           Console.WriteLine("-------------------------GetByIndex---------------------------\n");
            Console.WriteLine($"Get value by index = {st.GetByIndex(3)}\n");

            //GetKey
             Console.WriteLine("-------------------------GetKey---------------------------\n");
            Console.WriteLine($"Get key by giving index = {st.GetKey(2)}\n");

            //Remove
             Console.WriteLine("-------------------------Remove---------------------------\n");
            st.Remove("V");
            Console.WriteLine("after removing value of key V :");
            foreach (DictionaryEntry d in st)
            {
                Console.WriteLine($"key = {d.Key} & Value = {d.Value}");
            }

            //Clear
             Console.WriteLine("-------------------------Clear---------------------------\n");
            Console.WriteLine("Clearing the data of sortedList:");
            st.Clear();
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            
            //Count
            Console.WriteLine("-------------------------Count---------------------------\n");
            Console.WriteLine($"Count of sorted list data is {st.Count}");
        }
    }
}
